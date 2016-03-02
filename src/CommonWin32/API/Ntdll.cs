using CommonWin32.SystemInformation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace CommonWin32.API
{
    static class Ntdll
    {
        class NativeMethods
        {
            [DllImport("ntdll.dll", CharSet = CharSet.Unicode)]
            public static extern int RtlGetVersion([In, Out]ref OSVERSIONINFOEX version);
        }

        public static Version RtlGetVersion()
        {
            var v = default(OSVERSIONINFOEX);
            v.dwOSVersionInfoSize = (uint)Marshal.SizeOf(typeof(OSVERSIONINFOEX));
            if (NativeMethods.RtlGetVersion(ref v) == 0)
            {
                return new Version((int)v.dwMajorVersion, (int)v.dwMinorVersion, (int)v.dwBuildNumber, 0);
            }
            // didn't work ???
            return Environment.OSVersion.Version;
        }
    }
}
