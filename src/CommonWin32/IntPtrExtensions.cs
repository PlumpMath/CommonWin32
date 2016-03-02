﻿using CommonWin32.API;
using CommonWin32.Bitmaps;
using CommonWin32.Rectangles;
using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;
using System.Text;
using System.Windows.Media.Imaging;

namespace CommonWin32
{
    /// <summary>
    /// Contains useful things for <see cref="IntPtr"/>.
    /// </summary>
    public static class IntPtrExtensions
    {
        /// <summary>
        /// Correctly gets the mouse point location specified in lParam.
        /// </summary>
        /// <param name="lParam">The lParam from WndProc.</param>
        /// <returns></returns>
        public static POINT ToPoint(this IntPtr lParam)
        {
            // new from http://stackoverflow.com/questions/7913325/win-api-in-c-get-hi-and-low-word-from-intptr
            // to handle possible negative values from multi-monitor setup

            int x = unchecked((short)lParam);
            int y = unchecked((short)((uint)lParam >> 16));
            return new POINT { x = x, y = y };
        }

        class SafeHBitmapHandle : SafeHandleZeroOrMinusOneIsInvalid
        {
            [SecurityCritical]
            public SafeHBitmapHandle(IntPtr preexistingHandle, bool ownsHandle)
                : base(ownsHandle)
            {
                SetHandle(preexistingHandle);
            }

            protected override bool ReleaseHandle()
            {
                return Gdi32.DeleteObject(handle);
            }
        }

        /// <summary>
        /// Gets the image from a DIB pointer as a <see cref="Bitmap"/>.
        /// </summary>
        /// <param name="dibBitmap">The dib handle.</param>
        /// <returns></returns>
        [EnvironmentPermissionAttribute(SecurityAction.LinkDemand)]
        public static Bitmap GetDrawingBitmap(this IntPtr dibBitmap)
        {
            Bitmap finalImg = null;
            if (dibBitmap != IntPtr.Zero && IsDib(dibBitmap))
            {
                Bitmap tempImg = null;
                try
                {
                    BITMAPINFOHEADER header = (BITMAPINFOHEADER)Marshal.PtrToStructure(dibBitmap, typeof(BITMAPINFOHEADER));

                    if (header.Validate())
                    {
                        PixelFormat format = header.GetDrawingPixelFormat();
                        tempImg = new Bitmap(header.biWidth, Math.Abs(header.biHeight), header.GetStride(), format, header.GetScan0(dibBitmap));
                        ColorPalette pal = header.GetDrawingPalette(dibBitmap);
                        if (pal != null)
                        {
                            tempImg.Palette = pal;
                        }
                        float xdpi = header.GetXDpi();
                        float ydpi = header.GetYDpi();
                        if (xdpi != 0 && ydpi == 0)
                        {
                            ydpi = xdpi;
                        }
                        else if (ydpi != 0 && xdpi == 0)
                        {
                            xdpi = ydpi;
                        }
                        if (xdpi != 0)
                        {
                            tempImg.SetResolution(xdpi, ydpi);
                        }
                        if (header.IsBottomUpImage)
                        {
                            tempImg.RotateFlip(RotateFlipType.RotateNoneFlipY);
                        }
                        finalImg = tempImg;
                        tempImg = null;
                    }
                }
                finally
                {
                    if (tempImg != null)
                    {
                        tempImg.Dispose();
                    }
                }
            }
            return finalImg;
        }

        private static bool IsDib(IntPtr dibBitmap)
        {
            // a quick check not guaranteed correct,
            // compare first byte to size of struct (which is also the first field)
            var test = Marshal.ReadInt32(dibBitmap);
            // should be 40
            return test == BITMAPINFOHEADER.GetByteSize();
        }

        /// <summary>
        /// Gets the image from a DIB pointer as a WPF <see cref="BitmapSource"/>.
        /// </summary>
        /// <param name="dibBitmap">The dib bitmap.</param>
        /// <returns></returns>
        [EnvironmentPermissionAttribute(SecurityAction.LinkDemand)]
        public static BitmapSource GetWPFBitmap(this IntPtr dibBitmap)
        {
            using (var bm = GetDrawingBitmap(dibBitmap))
            {
                if (bm != null)
                {
                    using (var hbm = new SafeHBitmapHandle(bm.GetHbitmap(), true))
                    {
                        return System.Windows.Interop.Imaging.CreateBitmapSourceFromHBitmap(
                           hbm.DangerousGetHandle(),
                           IntPtr.Zero,
                           System.Windows.Int32Rect.Empty,
                           BitmapSizeOptions.FromEmptyOptions());
                    }
                }
            }

            return null;
        }
    }
}
