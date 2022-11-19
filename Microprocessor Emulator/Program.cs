﻿using Microprocessor_Emulator;
using System;
using System.Reflection.Metadata.Ecma335;

namespace Microprocessor_Emualtor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int selected;
            while (true) { 

                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("Please select the instruction you want to execute:  \n");
                Console.ResetColor();
              
                Console.WriteLine("(1) SUB Instruction\n");
                Console.WriteLine("(2) MOV Instruction\n");
                Console.WriteLine("(3) NOP Instruction\n");
                Console.WriteLine("(4) XOR Instruction\n");

                while (true) { 
                
                    int.TryParse(Console.ReadLine(), out selected);
                
                    switch(selected)
                        {

                        case 2:
                            MOVInstruction.MOV();
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