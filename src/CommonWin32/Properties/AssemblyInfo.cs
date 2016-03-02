using CommonWin32;
using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[assembly: AssemblyTitle("CommonWin32")]
[assembly: AssemblyDescription("A .net lib with common win32 values/types/routines for interop/pinvoke.")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("Yin-Chun Wang")]
[assembly: AssemblyProduct("CommonWin32")]
[assembly: AssemblyCopyright("Copyright © Yin-Chun Wang 2012-2016")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

[assembly: ComVisible(false)]
[assembly: Guid("873e45e9-41cb-48c7-b0d4-9b7702833f20")]

[assembly: CLSCompliant(false)]


[assembly: AssemblyVersion(_VersionString.Release)]
[assembly: AssemblyFileVersion(_VersionString.Build)]
[assembly: AssemblyInformationalVersion(_VersionString.Build)]

namespace CommonWin32
{
    class _VersionString
    {
        // keep this same in majors releases
        public const string Release = "2.0.0.0";
        // change this for each nuget release
        public const string Build = "2.1.0.3";
    }
}