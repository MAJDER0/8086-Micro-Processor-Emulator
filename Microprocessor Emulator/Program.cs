using System;
using System.Reflection.Metadata.Ecma335;

namespace Microprocessor_Emualtor
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            Console.WriteLine("Please select the instruction you want to execute:  ");

            Console.WriteLine();

            Console.WriteLine("Sub Instruction - 1");
            Console.WriteLine("Mov Instruction - 2");
            Console.WriteLine("NOP Instruction - 3");
            Console.WriteLine("XOR Instruction - 4");

            Console.WriteLine();

            int selected;
            int.TryParse(Console.ReadLine(), out selected);


            if (selected == 2)
            {


                Console.WriteLine("Select registry you want to enter the value: ");
                Console.WriteLine("(1) AX");
                Console.WriteLine("(2) BX");
                Console.WriteLine("(3) DX");

                Console.WriteLine();

                int ChoosenRegistry;
                int.TryParse(Console.ReadLine(), out ChoosenRegistry);

                if (ChoosenRegistry == 1)
                {
                    Console.WriteLine("You have choosen AX Registry, please enter value now: ");

                    Console.WriteLine();

                    int AxValue;
                    int.TryParse(Console.ReadLine(), out AxValue);

                    Console.WriteLine("Select registry you want to move that value in: ");
                    Console.WriteLine("(1) BX");
                    Console.WriteLine("(2) DX");

                    Console.WriteLine();

                    int SelectedRegistryToMove;
                    int.TryParse(Console.ReadLine(), out SelectedRegistryToMove);

                    if (SelectedRegistryToMove == 1)

                    {
                        Console.WriteLine("You have choosen BX registry, moving process is about to begin: ");

                        Console.WriteLine();

                        Console.WriteLine("Please wait. . .");
                        System.Threading.Thread.Sleep(1000);
                        Console.WriteLine("Please wait. . .");
                        System.Threading.Thread.Sleep(1000);
                        Console.WriteLine("Please wait. . .");
                        System.Threading.Thread.Sleep(1000);

                        Console.WriteLine();

                        Console.WriteLine($"BX value now: {AxValue}");


                    }
                }

            }

            else 
            {
                Console.WriteLine("Select correct registry!!");
            
            }

            

   

        }
    }
}