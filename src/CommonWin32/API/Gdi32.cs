﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using CommonWin32.Rectangles;

namespace CommonWin32.API
{
    /// <summary>
    /// API methods in gdi32.dll.
    /// </summary>
    public static class Gdi32
    {
        class NativeMethods
        {
            [DllImport("gdi32.dll", SetLastError = true)]
            public static extern IntPtr CreateRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect);

            [DllImport("gdi32.dll", SetLastError = true)]
            public static extern IntPtr CreateRectRgnIndirect([In] ref RECT rc);

            [DllImport("gdi32.dll", SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool DeleteObject(IntPtr hObject);
        }

        /// <summary>
        /// Creates a rectangular region.
        /// </summary>
        /// <param name="nLeftRect">Specifies the x-coordinate of the upper-left corner of the region in logical units.</param>
        /// <param name="nTopRect">Specifies the y-coordinate of the upper-left corner of the region in logical units.</param>
        /// <param name="nRightRect">Specifies the x-coordinate of the lower-right corner of the region in logical units.</param>
        /// <param name="nBottomRect">Specifies the y-coordinate of the lower-right corner of the region in logical units.</param>
        /// <returns></returns>
        public static IntPtr CreateRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect)
        {
            return NativeMethods.CreateRectRgn(nLeftRect, nTopRect, nRightRect, nBottomRect);
        }

        /// <summary>
        /// Creates a rectangular region.
        /// </summary>
        /// <param name="rc"> RECT structure that contains the coordinates of the upper-left and lower-right corners of the rectangle that defines the region in logical units.</param>
        /// <returns></returns>
        public static IntPtr CreateRectRgnIndirect(ref RECT rc)
        {
            return NativeMethods.CreateRectRgnIndirect(ref rc);
        }

        /// <summary>
        /// The DeleteObject function deletes a logical pen, brush, font, bitmap, region, or palette, freeing all system resources associated with the object. After the object is deleted, the specified handle is no longer valid.
        /// </summary>
        /// <param name="hObject">A handle to a logical pen, brush, font, bitmap, region, or palette.</param>
        /// <returns></returns>
        public static bool DeleteObject(IntPtr hObject)
        {
            return NativeMethods.DeleteObject(hObject);
        }
    }
}
