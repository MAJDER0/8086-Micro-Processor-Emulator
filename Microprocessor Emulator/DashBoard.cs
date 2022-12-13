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

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Version: Alpha-[0.0.1]\n");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("Notice: numbers and strings stored as bits of information are displayed as HEX values.\n" +
                "However, casual strings are stored and displayed as a sequence of characters.\n");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"AX: {Registries.AxValue}  BX: {Registries.BxValue}  CX: {Registries.CxValue}  DX: {Registries.DxValue}\n");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Please select the instruction you want to execute:  \n");
            Console.ResetColor();

            Console.WriteLine("(1) SET REGISTRY VALUES\n");
            Console.WriteLine("(2) MOV Instruction\n");
            Console.WriteLine("(3) ADD Instruction\n");
            Console.WriteLine("(4) SUB Instruction\n");
            Console.WriteLine("(5) RESET ALL REGISTRY VALUES\n");
            Console.WriteLine("\n(6) EXIT Emulator\n");
        }
    }
}
