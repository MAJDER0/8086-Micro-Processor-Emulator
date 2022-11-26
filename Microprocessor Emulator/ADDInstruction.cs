using Microprocessor_Emualtor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microprocessor_Emulator
{
    public static class ADDInstruction
    {
        public static void ADD()
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("What would you like to add?\n");
                Console.ResetColor();

                Console.WriteLine("(1)Add one registry value to another registry\n");
                Console.WriteLine("(2)Add value to choosen registry\n");

                int TriggerAction;

                int.TryParse(Console.ReadLine(), out TriggerAction);

                if (TriggerAction == 1)
                {
                   
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("Select registry you wanna add to another: \n");
                    Console.ResetColor();
                    Console.WriteLine("(1)AX");
                    Console.WriteLine("(2)BX");
                    Console.WriteLine("(3)CX");
                    Console.WriteLine("(4)DX");

                    int ChoosenRegistry;
                    int.TryParse(Console.ReadLine(), out ChoosenRegistry);

                    if (ChoosenRegistry == 1)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine("You have choosen AX registry.Select registry you wanna add AX to: \n");
                        Console.ResetColor();

                        Console.WriteLine("(1)BX");
                        Console.WriteLine("(2)CX");
                        Console.WriteLine("(3)DX");

                        int SelectedRegistryToAdd;
                        int.TryParse(Console.ReadLine(), out SelectedRegistryToAdd);

                        if (SelectedRegistryToAdd == 1)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            Console.WriteLine("You have choosen BX Registry, adding process is about to begin");
                            Console.ResetColor();

                            Registries.BxValue += Registries.AxValue;

                            Console.WriteLine("\nPlease wait. . .");
                            System.Threading.Thread.Sleep(1000);
                            Console.WriteLine("Please wait. . .");
                            System.Threading.Thread.Sleep(1000);
                            Console.WriteLine("Please wait. . .");
                            System.Threading.Thread.Sleep(1000);

                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("\nSuccess! AX registry value has been successfully added to BX registry value. Press any key to return.");
                            Console.ResetColor();
                            Console.ReadLine();
                            Program.Main();

                        }

                        if (SelectedRegistryToAdd == 2)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            Console.WriteLine("You have choosen CX Registry, adding process is about to begin");
                            Console.ResetColor();

                            Registries.CxValue += Registries.AxValue;

                            Console.WriteLine("\nPlease wait. . .");
                            System.Threading.Thread.Sleep(1000);
                            Console.WriteLine("Please wait. . .");
                            System.Threading.Thread.Sleep(1000);
                            Console.WriteLine("Please wait. . .");
                            System.Threading.Thread.Sleep(1000);

                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("\nSuccess! AX registry value has been successfully added to CX registry value. Press any key to return.");
                            Console.ResetColor();
                            Console.ReadLine();
                            Program.Main();

                        }

                        if (SelectedRegistryToAdd == 3)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            Console.WriteLine("You have choosen DX Registry, adding process is about to begin");
                            Console.ResetColor();

                            Registries.DxValue += Registries.AxValue;

                            Console.WriteLine("\nPlease wait. . .");
                            System.Threading.Thread.Sleep(1000);
                            Console.WriteLine("Please wait. . .");
                            System.Threading.Thread.Sleep(1000);
                            Console.WriteLine("Please wait. . .");
                            System.Threading.Thread.Sleep(1000);

                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("\nSuccess! AX registry value has been successfully added to DX registry value. Press any key to return.");
                            Console.ResetColor();
                            Console.ReadLine();
                            Program.Main();
                        }


                    }
                


                    if (ChoosenRegistry == 2)
                    {


                    }


                    if (ChoosenRegistry == 3)
                    {


                    }

                    if (ChoosenRegistry == 4)
                    {


                    }
                    else
                    {

                    }
                }


                if (TriggerAction == 2)
                {
                    Console.WriteLine("");
                }

                else
                {
                    Console.Clear();
                    continue;
                }
            }
        }
    }

}

