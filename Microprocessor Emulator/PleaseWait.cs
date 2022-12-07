using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microprocessor_Emulator
{
    public class PleaseWait
    {
        public static void Wait()
        {
            Console.WriteLine("\nPlease wait. . .");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Please wait. . .");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Please wait. . .");
            System.Threading.Thread.Sleep(1000);
        }
    }
}
