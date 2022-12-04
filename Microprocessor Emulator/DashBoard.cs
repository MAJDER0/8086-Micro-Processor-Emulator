using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microprocessor_Emulator
{
    public static class DashBoard
    {
        public static void Board()
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"AX (HEX): {Registries.AxValue} BX (HEX): {Registries.BxValue} CX (HEX): {Registries.CxValue} DX (HEX): {Registries.DxValue}\n");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Please select the instruction you want to execute:  \n");
            Console.ResetColor();

            Console.WriteLine("(1) SET REGISTRY VALUES\n");
            Console.WriteLine("(2) MOV Instruction\n");
            Console.WriteLine("(3) ADD Instruction\n");
            Console.WriteLine("(4) XOR Instruction\n");
        }
    }
}
