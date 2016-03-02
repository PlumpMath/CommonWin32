using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace CommonWin32.Bitmaps
{
    /// <summary>
    /// Describes a color consisting of relative intensities of red, green, and blue.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct RGBQUAD
    {
        /// <summary>
        /// The intensity of blue in the color.
        /// </summary>
        public byte rgbBlue;
        /// <summary>
        /// The intensity of green in the color.
        /// </summary>
        public byte rgbGreen;
        /// <summary>
        /// The intensity of red in the color.
        /// </summary>
        public byte rgbRed;
        /// <summary>
        /// This member is reserved and must be zero.
        /// </summary>
        byte rgbReserved;
    };
}
