using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using CallMethod;

namespace ConsoleApplication1
{
    class Program
    {
        [DllImport("\\Users\\OmerVarul\\source\\repos\\namePrint\\x64\\Debug\\namePrint.dll", CallingConvention=CallingConvention.Cdecl)]
        public static extern void namePrint();

        static void Main(string[] args)
        {
            namePrint();
            
        }
    }
}

