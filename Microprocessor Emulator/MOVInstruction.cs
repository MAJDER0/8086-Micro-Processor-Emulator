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

            
                Console.Clear();

                int TriggerAction;
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("Select one: \n");
                Console.ResetColor();

                Console.WriteLine("(1) Move registry value to choosen registry\n");
                Console.WriteLine("(2) Show current registries value\n");
                Console.WriteLine("() Press any other key to return menu\n");

                int.TryParse(Console.ReadLine(), out TriggerAction);
                Console.WriteLine();

                if (TriggerAction == 0)
                {
                    break;

                }

                if (TriggerAction == 2)
                {
                    Console.Clear();
                    Console.WriteLine($"\nAX Value: {Registries.AxValue}");
                    Console.WriteLine($"BX Value: {Registries.BxValue}");
                    Console.WriteLine($"DX Value: {Registries.DxValue}");
                    Console.WriteLine($"CX Value: {Registries.CxValue}");
                    Console.WriteLine();

                    Console.WriteLine("Press any key to come back\n");
                    Console.ReadLine();
                    continue;

                }


                if (TriggerAction == 1)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("Select registry you want to move value from: \n");
                    Console.ResetColor();
                    Console.WriteLine("(1) AX");
                    Console.WriteLine("(2) BX");
                    Console.WriteLine("(3) CX");
                    Console.WriteLine("(4) DX");
                    Console.WriteLine("() Any key to return\n");


                    while (true)
                    {

                        int ChoosenRegistry;
                        int.TryParse(Console.ReadLine(), out ChoosenRegistry);
                        Console.WriteLine();
                        Console.Clear();

                        if (ChoosenRegistry == 1)
                        {
                            while (true)
                            {

                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                Console.WriteLine("\nYou have choosen AX Registry.");
                                Console.ResetColor();


                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                Console.WriteLine("Choose registry you want to move that value in: \n");
                                Console.ResetColor();
                                Console.WriteLine("(1) BX");
                                Console.WriteLine("(2) CX");
                                Console.WriteLine("(3) DX\n");

                                while (true)
                                { 
                                    try { 

                                        int SelectedRegistryToMove = int.Parse(Console.ReadLine());
                                        Console.WriteLine();

                                        try
                                        {

                                            if (SelectedRegistryToMove == 1)

                                            {
                                                Console.Clear();
                                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                                Console.WriteLine("You have choosen BX registry, moving process is about to begin: \n");
                                                Console.ResetColor();

                                                Registries.BxValue = Registries.AxValue;
                                                Registries.AxValue = 0;

                                                Console.WriteLine("\nPlease wait. . .");
                                                System.Threading.Thread.Sleep(1000);
                                                Console.WriteLine("Please wait. . .");
                                                System.Threading.Thread.Sleep(1000);
                                                Console.WriteLine("Please wait. . .");
                                                System.Threading.Thread.Sleep(1000);

                                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                                Console.WriteLine("\nSuccess! Press any key to return");
                                                Console.ResetColor();
                                                Console.ReadLine();
                                                Program.Main();

                                            }

                                             if (SelectedRegistryToMove == 2)

                                            {
                                                Console.Clear();
                                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                                Console.WriteLine("You have choosen CX registry, moving process is about to begin: \n");
                                                Console.ResetColor();

                                                Registries.CxValue = Registries.AxValue;
                                                Registries.AxValue = 0;

                                                Console.WriteLine("\nPlease wait. . .");
                                                System.Threading.Thread.Sleep(1000);
                                                Console.WriteLine("Please wait. . .");
                                                System.Threading.Thread.Sleep(1000);
                                                Console.WriteLine("Please wait. . .");
                                                System.Threading.Thread.Sleep(1000);

                                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                                Console.WriteLine("\nSuccess! Press any key to return");
                                                Console.ResetColor();
                                                Console.ReadLine();
                                                Program.Main();

                                            }


                                            if (SelectedRegistryToMove == 3)

                                            {
                                                Console.Clear();
                                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                                Console.WriteLine("You have choosen DX registry, moving process is about to begin: \n");
                                                Console.ResetColor();

                                                Registries.DxValue = Registries.AxValue;
                                                Registries.AxValue = 0;

                                                Console.WriteLine("\nPlease wait. . .");
                                                System.Threading.Thread.Sleep(1000);
                                                Console.WriteLine("Please wait. . .");
                                                System.Threading.Thread.Sleep(1000);
                                                Console.WriteLine("Please wait. . .");
                                                System.Threading.Thread.Sleep(1000);

                                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                                Console.WriteLine("\nSuccess! Press any key to return");
                                                Console.ResetColor();
                                                Console.ReadLine();
                                                Program.Main();

                                            }

                                            else
                                            {
                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                Console.WriteLine("Please choosen correct registry!");
                                                Console.ResetColor();
                                                continue;

                                            }
                                        }
                                        catch 
                                        {
                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                            Console.WriteLine("An error has occured. Overflow or null has been entered. Please introduce correct number. Press Any key to try again!");
                                            Console.ResetColor();
                                            Console.ReadLine();
                                            continue;
                                        }
                                    }

                                    catch 
                                    {
                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                            Console.WriteLine("An error has occured. Overflow or null has been entered. Please introduce correct number. Press Any key to try again!");
                                            Console.ResetColor();
                                            Console.ReadLine();
                                            continue;
                                    }
                                }

                            }

                        }





                        if (ChoosenRegistry == 2)
                        {
                            while (true)
                            {

                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                Console.WriteLine("\nYou have choosen BX Registry.");
                                Console.ResetColor();


                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                Console.WriteLine("Choose registry you want to move that value in: \n");
                                Console.ResetColor();
                                Console.WriteLine("(1) AX");
                                Console.WriteLine("(2) CX");
                                Console.WriteLine("(3) DX\n");

                                while (true)
                                {
                                    try { 
                                        int SelectedRegistryToMove = int.Parse(Console.ReadLine());
                                        Console.WriteLine();

                                        try
                                        {

                                            if (SelectedRegistryToMove == 1)

                                            {
                                                Console.Clear();
                                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                                Console.WriteLine("You have choosen AX registry, moving process is about to begin: \n");
                                                Console.ResetColor();

                                                Registries.AxValue = Registries.BxValue;
                                                Registries.BxValue = 0;

                                                Console.WriteLine("\nPlease wait. . .");
                                                System.Threading.Thread.Sleep(1000);
                                                Console.WriteLine("Please wait. . .");
                                                System.Threading.Thread.Sleep(1000);
                                                Console.WriteLine("Please wait. . .");
                                                System.Threading.Thread.Sleep(1000);

                                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                                Console.WriteLine("\nSuccess! Press any key to return");
                                                Console.ResetColor();
                                                Console.ReadLine();
                                                Program.Main();

                                            }

                                            if (SelectedRegistryToMove == 2)

                                            {
                                                Console.Clear();
                                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                                Console.WriteLine("You have choosen CX registry, moving process is about to begin: \n");
                                                Console.ResetColor();

                                                Registries.CxValue = Registries.BxValue;
                                                Registries.BxValue = 0;

                                                Console.WriteLine("\nPlease wait. . .");
                                                System.Threading.Thread.Sleep(1000);
                                                Console.WriteLine("Please wait. . .");
                                                System.Threading.Thread.Sleep(1000);
                                                Console.WriteLine("Please wait. . .");
                                                System.Threading.Thread.Sleep(1000);

                                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                                Console.WriteLine("\nSuccess! Press any key to return");
                                                Console.ResetColor();
                                                Console.ReadLine();
                                                Program.Main();

                                            }



                                            if (SelectedRegistryToMove == 3)

                                            {
                                                Console.Clear();
                                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                                Console.WriteLine("You have choosen DX registry, moving process is about to begin: \n");
                                                Console.ResetColor();

                                                Registries.DxValue = Registries.BxValue;
                                                Registries.BxValue = 0;

                                                Console.WriteLine("\nPlease wait. . .");
                                                System.Threading.Thread.Sleep(1000);
                                                Console.WriteLine("Please wait. . .");
                                                System.Threading.Thread.Sleep(1000);
                                                Console.WriteLine("Please wait. . .");
                                                System.Threading.Thread.Sleep(1000);

                                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                                Console.WriteLine("\nSuccess! Press any key to return");
                                                Console.ResetColor();
                                                Console.ReadLine();
                                                Program.Main();

                                            }

                                            else
                                            {
                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                Console.WriteLine("Please choosen correct registry!");
                                                Console.ResetColor();
                                                continue;

                                            }
                                        }
                                        catch
                                        {
                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                            Console.WriteLine("An error has occured. Overflow or null has been entered. Please introduce correct number. Press Any key to try again!");
                                            Console.ResetColor();
                                            Console.ReadLine();
                                            continue;
                                        }
                                    }

                                    catch 
                                    {
                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                            Console.WriteLine("An error has occured. Overflow or null has been entered. Please introduce correct number. Press Any key to try again!");
                                            Console.ResetColor();
                                            Console.ReadLine();
                                            continue;
                                    }
                                }

                            }

                        }




                        if (ChoosenRegistry == 3)
                        {
                            while (true)
                            {

                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                Console.WriteLine("\nYou have choosen CX Registry.");
                                Console.ResetColor();


                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                Console.WriteLine("Choose registry you want to move that value in: \n");
                                Console.ResetColor();
                                Console.WriteLine("(1) AX");
                                Console.WriteLine("(2) BX");
                                Console.WriteLine("(3) DX\n");

                                while (true)
                                {
                                    try { 
                                        int SelectedRegistryToMove = int.Parse(Console.ReadLine());
                                        Console.WriteLine();

                                        try
                                        {

                                            if (SelectedRegistryToMove == 1)

                                            {
                                                Console.Clear();
                                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                                Console.WriteLine("You have choosen AX registry, moving process is about to begin: \n");
                                                Console.ResetColor();

                                                Registries.AxValue = Registries.CxValue;
                                                Registries.CxValue = 0;

                                                Console.WriteLine("\nPlease wait. . .");
                                                System.Threading.Thread.Sleep(1000);
                                                Console.WriteLine("Please wait. . .");
                                                System.Threading.Thread.Sleep(1000);
                                                Console.WriteLine("Please wait. . .");
                                                System.Threading.Thread.Sleep(1000);

                                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                                Console.WriteLine("\nSuccess! Press any key to return");
                                                Console.ResetColor();
                                                Console.ReadLine();
                                                Program.Main();

                                            }

                                        
                                            if (SelectedRegistryToMove == 2)

                                            {
                                                Console.Clear();
                                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                                Console.WriteLine("You have choosen BX registry, moving process is about to begin: \n");
                                                Console.ResetColor();

                                                Registries.BxValue = Registries.CxValue;
                                                Registries.CxValue = 0;

                                                Console.WriteLine("\nPlease wait. . .");
                                                System.Threading.Thread.Sleep(1000);
                                                Console.WriteLine("Please wait. . .");
                                                System.Threading.Thread.Sleep(1000);
                                                Console.WriteLine("Please wait. . .");
                                                System.Threading.Thread.Sleep(1000);

                                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                                Console.WriteLine("\nSuccess! Press any key to return");
                                                Console.ResetColor();
                                                Console.ReadLine();
                                                Program.Main();

                                            }

                                            if (SelectedRegistryToMove == 3)

                                            {
                                                Console.Clear();
                                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                                Console.WriteLine("You have choosen DX registry, moving process is about to begin: \n");
                                                Console.ResetColor();

                                                Registries.DxValue = Registries.CxValue;
                                                Registries.CxValue = 0;

                                                Console.WriteLine("\nPlease wait. . .");
                                                System.Threading.Thread.Sleep(1000);
                                                Console.WriteLine("Please wait. . .");
                                                System.Threading.Thread.Sleep(1000);
                                                Console.WriteLine("Please wait. . .");
                                                System.Threading.Thread.Sleep(1000);

                                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                                Console.WriteLine("\nSuccess! Press any key to return");
                                                Console.ResetColor();
                                                Console.ReadLine();
                                                Program.Main();

                                            }

                                            else
                                            {
                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                Console.WriteLine("Please choosen correct registry!");
                                                Console.ResetColor();
                                                continue;

                                            }
                                        }
                                        catch
                                        {
                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                            Console.WriteLine("An error has occured. Overflow or null has been entered. Please introduce correct number. Press Any key to try again!");
                                            Console.ResetColor();
                                            Console.ReadLine();
                                            continue;
                                        }

                                    }

                                    catch 
                                    {
                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                            Console.WriteLine("An error has occured. Overflow or null has been entered. Please introduce correct number. Press Any key to try again!");
                                            Console.ResetColor();
                                            Console.ReadLine();
                                            continue;
                                    }
                                }

                            }

                        }






                        if (ChoosenRegistry == 4)
                        {
                            while (true)
                            {

                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                Console.WriteLine("\nYou have choosen DX Registry.");
                                Console.ResetColor();


                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                Console.WriteLine("Choose registry you want to move that value in: \n");
                                Console.ResetColor();
                                Console.WriteLine("(1) AX");
                                Console.WriteLine("(2) BX");
                                Console.WriteLine("(3) CX\n");

                                while (true)
                                {
                                    try { 
                                     int SelectedRegistryToMove = int.Parse(Console.ReadLine());
                                     Console.WriteLine();

                                        try
                                        {

                                            if (SelectedRegistryToMove == 1)

                                            {
                                                Console.Clear();
                                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                                Console.WriteLine("You have choosen AX registry, moving process is about to begin: \n");
                                                Console.ResetColor();

                                                Registries.AxValue = Registries.DxValue;
                                                Registries.DxValue = 0;

                                                Console.WriteLine("\nPlease wait. . .");
                                                System.Threading.Thread.Sleep(1000);
                                                Console.WriteLine("Please wait. . .");
                                                System.Threading.Thread.Sleep(1000);
                                                Console.WriteLine("Please wait. . .");
                                                System.Threading.Thread.Sleep(1000);

                                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                                Console.WriteLine("\nSuccess! Press any key to return");
                                                Console.ResetColor();
                                                Console.ReadLine();
                                                Program.Main();

                                            }

                                            if (SelectedRegistryToMove == 2)

                                            {
                                                Console.Clear();
                                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                                Console.WriteLine("You have choosen BX registry, moving process is about to begin: \n");
                                                Console.ResetColor();

                                                Registries.BxValue = Registries.DxValue;
                                                Registries.DxValue = 0;

                                                Console.WriteLine("\nPlease wait. . .");
                                                System.Threading.Thread.Sleep(1000);
                                                Console.WriteLine("Please wait. . .");
                                                System.Threading.Thread.Sleep(1000);
                                                Console.WriteLine("Please wait. . .");
                                                System.Threading.Thread.Sleep(1000);

                                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                                Console.WriteLine("\nSuccess! Press any key to return");
                                                Console.ResetColor();
                                                Console.ReadLine();
                                                Program.Main();

                                            }

                                            if (SelectedRegistryToMove == 3)

                                            {
                                                Console.Clear();
                                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                                Console.WriteLine("You have choosen CX registry, moving process is about to begin: \n");
                                                Console.ResetColor();

                                                Registries.CxValue = Registries.DxValue;
                                                Registries.DxValue = 0;

                                                Console.WriteLine("\nPlease wait. . .");
                                                System.Threading.Thread.Sleep(1000);
                                                Console.WriteLine("Please wait. . .");
                                                System.Threading.Thread.Sleep(1000);
                                                Console.WriteLine("Please wait. . .");
                                                System.Threading.Thread.Sleep(1000);

                                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                                Console.WriteLine("\nSuccess! Press any key to return");
                                                Console.ResetColor();
                                                Console.ReadLine();
                                                Program.Main();

                                            }




                                            else
                                            {
                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                Console.WriteLine("Please choosen correct registry!");
                                                Console.ResetColor();
                                                continue;

                                            }
                                        }
                                        catch
                                        {
                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                            Console.WriteLine("An error has occured. Overflow or null has been entered. Please introduce correct number. Press Any key to try again!");
                                            Console.ResetColor();
                                            Console.ReadLine();
                                            continue;
                                        }
                                    }

                                    catch 
                                    {
                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                            Console.WriteLine("An error has occured. Overflow or null has been entered. Please introduce correct number. Press Any key to try again!");
                                            Console.ResetColor();
                                            Console.ReadLine();
                                            continue;
                                    }

                                }
                            }

                        }

                        if (ChoosenRegistry == 0) { break; }

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
