using Microprocessor_Emulator;
using System;
using System.Reflection.Metadata.Ecma335;

namespace Microprocessor_Emualtor
{
    public static class Program
    {
        public static void Main()
        {
            while (true) {

                DashBoard.Board();

                while (true) {

                    int selected;
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