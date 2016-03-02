using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace CommonWin32.DeviceManagement
{
    /// <summary>
    /// Contains information about a modem, serial, or parallel port.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct DEV_BROADCAST_PORT
    {
        /// <summary>
        /// Gets a value indicating whether this struct is supported on current platform.
        /// </summary>
        /// <value>
        /// <c>true</c> if this struct is supported; otherwise, <c>false</c>.
        /// </value>
        public static bool IsSupported { get { return PlatformInfo.IsWinXPUp; } }

        /// <summary>
        /// The size of this structure, in bytes. This is the size of the members plus the actual length of the dbcp_name  string (the null character is accounted for by the declaration of dbcc_name as a one-character array.).
        /// </summary>
        public uint dbcp_size;
        /// <summary>
        /// Set to DBT_DEVTYP_PORT.
        /// </summary>
        public DEV_BROADCAST_HDR.DeviceType dbcp_devicetype;
        /// <summary>
        /// Reserved; do not use.
        /// </summary>
        public uint dbcp_reserved;
        /// <summary>
        /// A null-terminated string specifying the friendly name of the port or the device connected to the port. Friendly names are intended to help the user quickly and accurately identify the device—for example, "COM1" and "Standard 28800 bps Modem" are considered friendly names.
        /// </summary>
        [MarshalAs(UnmanagedType.LPTStr)]
        public string dbcp_name;
    }
}
