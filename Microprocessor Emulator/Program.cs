using Microprocessor_Emulator;
using System;
using System.Reflection.Metadata.Ecma335;

namespace Microprocessor_Emualtor
{
    public static class Program
    {
        public static void Main()
        {
            int selected;
            while (true) { 

                Console.Clear();
                
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"AX: {Registries.AxValue} BX: {Registries.BxValue} CX: {Registries.CxValue} DX: {Registries.DxValue}\n");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("Please select the instruction you want to execute:  \n");
                Console.ResetColor();
              
                Console.WriteLine("(1) SET REGISTRY VALUES\n");
                Console.WriteLine("(2) MOV Instruction\n");
                Console.WriteLine("(3) ADD Instruction\n");
                Console.WriteLine("(4) XOR Instruction\n");

                while (true) { 
                
                    int.TryParse(Console.ReadLine(), out selected);
                
                    switch(selected)
                        {

                        case 1:
                            Console.Clear();
                            SET.SETValues();
                            break;

                        case 2:
                            Console.Clear();
                            MOVInstruction.MOV();
                        break;

                        case 3:
                            Console.Clear();
                            ADDInstruction.ADD();
                            break;

                        default:
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Please choose correct instruction!");
                        Console.ResetColor();
                        continue;

                    }
                      
                    break;                   
                }
            }
        }

    }
}