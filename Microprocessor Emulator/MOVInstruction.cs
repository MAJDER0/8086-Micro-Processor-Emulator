using Microprocessor_Emualtor;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Microprocessor_Emulator
{
    public static class MOVInstruction
    {
       
        public static void MOV()
        {
            while (true)
            {
                
                Start:
                Console.Clear();

                int TriggerAction;
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("Select one: \n");
                Console.ResetColor();

                Console.WriteLine("(1) Show current registries value\n");
                Console.WriteLine("(2) Enter value to choosen registry\n");
                Console.WriteLine("() Press any other key to return menu\n");

                int.TryParse(Console.ReadLine(), out TriggerAction);
                Console.WriteLine();

                if (TriggerAction == 0)
                {
                    break;

                }

                if (TriggerAction == 1)
                {
                    Console.Clear();
                    Console.WriteLine($"\nAX Value: {Registries.AxValue}");
                    Console.WriteLine($"BX Value: {Registries.BxValue}");
                    Console.WriteLine($"DX Value: {Registries.DxValue}");
                    Console.WriteLine();

                    Console.WriteLine("Press any key to come back\n");
                    Console.ReadLine();
                    continue;

                }


                if (TriggerAction == 2)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("Select registry you want to enter the value: \n");
                    Console.ResetColor();
                    Console.WriteLine("(1) AX");
                    Console.WriteLine("(2) BX");
                    Console.WriteLine("(3) DX\n");
                    Console.WriteLine("() Any key to return\n");


                    while (true)
                    {

                        int ChoosenRegistry;
                        int.TryParse(Console.ReadLine(), out ChoosenRegistry);
                        Console.WriteLine();

                        if (ChoosenRegistry == 1)
                        {
                            while (true)
                            {
                                
                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                Console.WriteLine("You have choosen AX Registry, please enter value now: \n");
                                Console.ResetColor();

                                int AxResult;
                                int.TryParse(Console.ReadLine(), out AxResult);
                                Console.WriteLine();

                                if (Enumerable.Range(-32767, 65535).Contains(AxResult))
                                {
                                    Console.Clear();
                                    Registries.AxValue = AxResult;

                                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                    Console.WriteLine("Select registry you want to move that value in: \n");
                                    Console.ResetColor();
                                    Console.WriteLine("(1) BX");
                                    Console.WriteLine("(2) DX\n");

                                    while (true)
                                    {

                                        int SelectedRegistryToMove;
                                        int.TryParse(Console.ReadLine(), out SelectedRegistryToMove);
                                        Console.WriteLine();

                                        if (SelectedRegistryToMove == 1)

                                        {
                                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                            Console.WriteLine("You have choosen BX registry, moving process is about to begin: \n");
                                            Console.ResetColor();

                                            Registries.BxValue = Registries.AxValue;
                                            Registries.AxValue = 0;

                                            Console.WriteLine("Please wait. . .");
                                            System.Threading.Thread.Sleep(1000);
                                            Console.WriteLine("Please wait. . .");
                                            System.Threading.Thread.Sleep(1000);
                                            Console.WriteLine("Please wait. . .");
                                            System.Threading.Thread.Sleep(1000);

                                            Console.WriteLine();

                                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                                            Console.WriteLine($"BX value now: {Registries.BxValue}");
                                            Console.ResetColor();

                                            Console.WriteLine("Press any key to come back");
                                            Console.ReadLine();
                                            goto Start;
                                            

                                        }

                                        if (SelectedRegistryToMove == 2)
                                        {
                                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                            Console.WriteLine("You have choosen DX registry, moving process is about to begin: \n");
                                            Console.ResetColor();

                                            Registries.DxValue = Registries.AxValue;
                                            Registries.AxValue = 0;


                                            Console.WriteLine("Please wait. . .");
                                            System.Threading.Thread.Sleep(1000);
                                            Console.WriteLine("Please wait. . .");
                                            System.Threading.Thread.Sleep(1000);
                                            Console.WriteLine("Please wait. . .");
                                            System.Threading.Thread.Sleep(1000);

                                            Console.WriteLine();

                                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                                            Console.WriteLine($"DX value now: {Registries.DxValue}");
                                            Console.ResetColor();

                                            Console.WriteLine("Press any key to come back");
                                            Console.ReadLine();
                                            goto Start;
                                        }

                                        else
                                        {
                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                            Console.WriteLine("Please choose correct registry to copy");
                                            Console.ResetColor();
                                            continue;
                                        }

                                    }
                                    break;
                                }

                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine("Your number has exceeded 16 bits or you haven't entered any value, please enter correct number");
                                    Console.ResetColor();
                                    continue;
                                }                            
                              
                            }

                        }





                        if (ChoosenRegistry == 2)
                        {
                            while (true)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                Console.WriteLine("You have choosen BX Registry, please enter value now: \n");
                                Console.ResetColor();

                                int BxResult;
                                int.TryParse(Console.ReadLine(), out BxResult);
                                Console.WriteLine();


                                if (Enumerable.Range(-32767, 65535).Contains(BxResult))
                                {
                                    Console.Clear();
                                    Registries.BxValue = BxResult;

                                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                    Console.WriteLine("Select registry you want to move that value in: \n");
                                    Console.ResetColor();
                                    Console.WriteLine("(1) AX");
                                    Console.WriteLine("(2) DX");

                                    Console.WriteLine();
                                    while (true)
                                    {

                                        int SelectedRegistryToMove;
                                        int.TryParse(Console.ReadLine(), out SelectedRegistryToMove);
                                        Console.WriteLine();

                                        if (SelectedRegistryToMove == 1)

                                        {
                                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                            Console.WriteLine("You have choosen AX registry, moving process is about to begin: \n");
                                            Console.ResetColor();

                                            Registries.AxValue = Registries.BxValue;
                                            Registries.BxValue = 0;

                                            Console.WriteLine("Please wait. . .");
                                            System.Threading.Thread.Sleep(1000);
                                            Console.WriteLine("Please wait. . .");
                                            System.Threading.Thread.Sleep(1000);
                                            Console.WriteLine("Please wait. . .");
                                            System.Threading.Thread.Sleep(1000);

                                            Console.WriteLine();

                                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                                            Console.WriteLine($"AX value now: {Registries.AxValue}");
                                            Console.ResetColor();

                                            Console.WriteLine("Press any key to come back");
                                            Console.ReadKey();
                                            goto Start;

                                        }

                                        if (SelectedRegistryToMove == 2)

                                        {
                                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                            Console.WriteLine("You have choosen DX registry, moving process is about to begin: \n");
                                            Console.ResetColor();

                                            Registries.DxValue = Registries.BxValue;
                                            Registries.BxValue = 0;

                                            Console.WriteLine("Please wait. . .");
                                            System.Threading.Thread.Sleep(1000);
                                            Console.WriteLine("Please wait. . .");
                                            System.Threading.Thread.Sleep(1000);
                                            Console.WriteLine("Please wait. . .");
                                            System.Threading.Thread.Sleep(1000);

                                            Console.WriteLine();

                                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                                            Console.WriteLine($"DX value now: {Registries.DxValue}");
                                            Console.ResetColor();

                                            Console.WriteLine("Press any key to come back");
                                            Console.ReadKey();
                                            goto Start;

                                        }

                                        else
                                        {
                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                            Console.WriteLine("Please choose correct registry to copy");
                                            Console.ResetColor();
                                            continue;
                                        }
                                    }

                                    break;

                                }
                                else
                                {

                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine("Your number has exceeded 16 bits or you haven't entered any value, please enter correct number");
                                    Console.ResetColor();
                                    continue;

                                }
                            }
                        }




                        if (ChoosenRegistry == 3)
                        {
                            while (true) { 
                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                Console.WriteLine("You have choosen DX Registry, please enter value now: \n");
                                Console.ResetColor();

                                int DxResult;
                                int.TryParse(Console.ReadLine(), out DxResult);
                                Console.WriteLine();

                                if (Enumerable.Range(-32767, 65535).Contains(DxResult)) 
                                {
                                    Console.Clear();
                                    Registries.DxValue = DxResult;

                                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                    Console.WriteLine("Select registry you want to move that value in: \n");
                                    Console.ResetColor();
                                    Console.WriteLine("(1) AX");
                                    Console.WriteLine("(2) BX\n");

                                    while (true)
                                    {
                                        int SelectedRegistryToMove;
                                        int.TryParse(Console.ReadLine(), out SelectedRegistryToMove);

                                        if (SelectedRegistryToMove == 1)

                                        {
                                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                            Console.WriteLine("You have choosen AX registry, moving process is about to begin: \n");
                                            Console.ResetColor();

                                            Registries.AxValue = Registries.DxValue;
                                            Registries.DxValue = 0;

                                            Console.WriteLine("Please wait. . .");
                                            System.Threading.Thread.Sleep(1000);
                                            Console.WriteLine("Please wait. . .");
                                            System.Threading.Thread.Sleep(1000);
                                            Console.WriteLine("Please wait. . .");
                                            System.Threading.Thread.Sleep(1000);

                                            Console.WriteLine();

                                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                                            Console.WriteLine($"AX value now: {Registries.AxValue}");
                                            Console.ResetColor();

                                            Console.WriteLine("Press any key to come back");
                                            Console.ReadKey();
                                            goto Start;

                                        }

                                        if (SelectedRegistryToMove == 2)

                                        {
                                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                            Console.WriteLine("You have choosen BX registry, moving process is about to begin: \n");
                                            Console.ResetColor();

                                            Registries.BxValue = Registries.DxValue;
                                            Registries.DxValue = 0;

                                            Console.WriteLine("Please wait. . .");
                                            System.Threading.Thread.Sleep(1000);
                                            Console.WriteLine("Please wait. . .");
                                            System.Threading.Thread.Sleep(1000);
                                            Console.WriteLine("Please wait. . .");
                                            System.Threading.Thread.Sleep(1000);

                                            Console.WriteLine();

                                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                                            Console.WriteLine($"BX value now: {Registries.BxValue}");
                                            Console.ResetColor();

                                            Console.WriteLine("Press any key to come back");
                                            Console.ReadKey();
                                            goto Start;

                                        }

                                        else
                                        {
                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                            Console.WriteLine("Please choose correct registry to copy");
                                            Console.ResetColor();
                                            continue;
                                        }

                                    }

                                    break;
                                }

                                else
                                {

                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine("Your number has exceeded 16 bits or you haven't entered any value, please enter correct number");
                                    Console.ResetColor();
                                    continue;

                                }

                            }
                        }

                        if (ChoosenRegistry == 0) { break;}

                        else
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Choose correctly");
                            Console.ResetColor();
                            continue;
                        }
                       
                    }
                    continue;
                }

                break;

            }
        }
    }


}
