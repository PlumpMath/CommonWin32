using CommonWin32;
using CommonWin32.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace NetSizes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Win 2000..." + PlatformInfo.IsWin2kUp);
            Console.WriteLine("Win XP..." + PlatformInfo.IsWinXPUp);
            Console.WriteLine("Win Vista..." + PlatformInfo.IsWinVistaUp);
            Console.WriteLine("Win 7..." + PlatformInfo.IsWin7Up);
            Console.WriteLine("Win 8..." + PlatformInfo.IsWin8Up);
            Console.WriteLine("Win 8.1..." + PlatformInfo.IsWin81Up);
            Console.WriteLine("Win 10..." + PlatformInfo.IsWin10Up);

            Console.WriteLine("DWM composition..." + Dwmapi.IsCompositionEnabled);



            var structTypes = (from t in typeof(HRESULT).Assembly.GetTypes()
                               where t.IsValueType && !t.IsPrimitive && !t.IsEnum
                               select t).OrderBy(t => t.Name);
            foreach (var st in structTypes)
            {
                Console.WriteLine("{0} = {1}", st.Name, Marshal.SizeOf(st));
            }

            Console.ReadLine();
        }
    }
}
