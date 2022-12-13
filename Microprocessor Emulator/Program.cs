using Microprocessor_Emulator;
using System;
using System.Reflection.Metadata.Ecma335;

namespace Microprocessor_Emualtor
{
    public static class Program
    {
        public static void Main()
        {
            while (true)
            {
                DashBoard.Board();

                while (true)
                {
                    int.TryParse(Console.ReadLine(), out int selected);

                    switch (selected)
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

                        case 4:
                            Console.Clear();
                            SUBInstruction.SUB();
                            break;

                        case 5:
                            Console.Clear();
                            Reset.ResetValues();
                            break;

                        case 6:
                            System.Environment.Exit(0);
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