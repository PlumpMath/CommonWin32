using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace CommonWin32.MouseInput
{

    /// <summary>
    /// Used by the TrackMouseEvent function to track when the mouse pointer 
    /// leaves a window or hovers over a window for a specified amount of time.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct TRACKMOUSEEVENT
    {
        /// <summary>
        /// The size of the TRACKMOUSEEVENT structure, in bytes.
        /// </summary>
        public uint cbSize;
        /// <summary>
        /// The services requested. 
        /// </summary>
        public EventFlags dwFlags;
        /// <summary>
        /// A handle to the window to track.
        /// </summary>
        public IntPtr hwndTrack;
        /// <summary>
        /// The hover time-out (if TME_HOVER was specified in dwFlags), in milliseconds.
        /// default is 400.
        /// </summary>
        public uint dwHoverTime;
    }
}
