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
                Console.WriteLine("() Press any other key to return menu\n");

                int.TryParse(Console.ReadLine(), out TriggerAction);
                Console.WriteLine();

                if (TriggerAction == 1)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("Select registry you want to move value from: \n");
                    Console.ResetColor();
                    Console.WriteLine("(1) AX\n");
                    Console.WriteLine("(2) BX\n");
                    Console.WriteLine("(3) CX\n");
                    Console.WriteLine("(4) DX\n");
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
                                Console.WriteLine("(1) BX\n");
                                Console.WriteLine("(2) CX\n");
                                Console.WriteLine("(3) DX\n");

                                while (true)
                                {
                                    bool isNumber = int.TryParse(Console.ReadLine(), out int SelectedRegistryToMove);
                                    Console.WriteLine();

                                    if (isNumber) { 

                                        try
                                        {
                                            if (SelectedRegistryToMove == 1)

                                            {
                                                Console.Clear();
                                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                                Console.WriteLine("You have choosen BX registry, moving process is about to begin: \n");
                                                Console.ResetColor();

                                                Registries.BxValue = Registries.AxValue;
                                                Registries.BxToAddAndSub = Registries.AxToAddAndSub;
                                                Registries.BxValueStringOnly = Registries.AxValueStringOnly;
                                                Registries.AxValue = 0.ToString();
                                                Registries.AxToAddAndSub = 0;
                                                Registries.AxValueStringOnly = 0.ToString();

                                                PleaseWait.Wait();

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
                                                Registries.CxToAddAndSub = Registries.AxToAddAndSub;
                                                Registries.CxValueStringOnly = Registries.AxValueStringOnly;
                                                Registries.AxValue = 0.ToString();
                                                Registries.AxToAddAndSub = 0;
                                                Registries.AxValueStringOnly = 0.ToString();

                                                PleaseWait.Wait();

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
                                                Registries.DxToAddAndSub = Registries.AxToAddAndSub;
                                                Registries.DxValueStringOnly = Registries.AxValueStringOnly;
                                                Registries.AxValue = 0.ToString();
                                                Registries.AxToAddAndSub = 0;
                                                Registries.AxValueStringOnly = 0.ToString();

                                                PleaseWait.Wait();

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

                                    else 
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
                                Console.WriteLine("(1) AX\n");
                                Console.WriteLine("(2) CX\n");
                                Console.WriteLine("(3) DX\n");

                                while (true)
                                {
                                    bool isNumber = int.TryParse(Console.ReadLine(), out int SelectedRegistryToMove);
                                    Console.WriteLine();

                                    if (isNumber) { 

                                        try
                                        {

                                            if (SelectedRegistryToMove == 1)

                                            {
                                                Console.Clear();
                                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                                Console.WriteLine("You have choosen AX registry, moving process is about to begin: \n");
                                                Console.ResetColor();

                                                Registries.AxValue = Registries.BxValue;
                                                Registries.AxToAddAndSub = Registries.BxToAddAndSub;
                                                Registries.AxValueStringOnly = Registries.BxValueStringOnly;
                                                Registries.BxValue = 0.ToString();
                                                Registries.BxToAddAndSub = 0;
                                                Registries.BxValueStringOnly=0.ToString();

                                                PleaseWait.Wait();

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
                                                Registries.CxToAddAndSub = Registries.BxToAddAndSub;
                                                Registries.CxValueStringOnly = Registries.BxValueStringOnly;
                                                Registries.BxValue = 0.ToString();
                                                Registries.BxToAddAndSub = 0;
                                                Registries.BxValueStringOnly = 0.ToString();

                                                PleaseWait.Wait();

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
                                                Registries.DxToAddAndSub = Registries.BxToAddAndSub;
                                                Registries.DxValueStringOnly = Registries.BxValueStringOnly;
                                                Registries.BxValue = 0.ToString();
                                                Registries.BxToAddAndSub= 0;
                                                Registries.BxValueStringOnly = 0.ToString();

                                                PleaseWait.Wait();

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

                                    else 
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
                                Console.WriteLine("(1) AX\n");
                                Console.WriteLine("(2) BX\n");
                                Console.WriteLine("(3) DX\n");

                                while (true)
                                {
                                    bool isNumber = int.TryParse(Console.ReadLine(), out int SelectedRegistryToMove);
                                    Console.WriteLine();

                                    if(isNumber) { 
                                        try
                                        {
                                            if (SelectedRegistryToMove == 1)

                                            {
                                                Console.Clear();
                                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                                Console.WriteLine("You have choosen AX registry, moving process is about to begin: \n");
                                                Console.ResetColor();

                                                Registries.AxValue = Registries.CxValue;
                                                Registries.AxToAddAndSub = Registries.CxToAddAndSub;
                                                Registries.AxValueStringOnly = Registries.CxValueStringOnly;
                                                Registries.CxValue = 0.ToString();
                                                Registries.CxToAddAndSub = 0;
                                                Registries.CxValueStringOnly = 0.ToString();

                                                PleaseWait.Wait();

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
                                                Registries.BxToAddAndSub = Registries.CxToAddAndSub;
                                                Registries.BxValueStringOnly = Registries.CxValueStringOnly;
                                                Registries.CxToAddAndSub = 0;
                                                Registries.CxValue = 0.ToString();
                                                Registries.CxValueStringOnly = 0.ToString();

                                                PleaseWait.Wait();

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
                                                Registries.DxToAddAndSub = Registries.CxToAddAndSub;
                                                Registries.DxValueStringOnly = Registries.CxValueStringOnly;
                                                Registries.CxToAddAndSub=0;
                                                Registries.CxValue = 0.ToString();
                                                Registries.CxValueStringOnly = 0.ToString();

                                                PleaseWait.Wait();

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

                                    else 
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
                                Console.WriteLine("(1) AX\n");
                                Console.WriteLine("(2) BX\n");
                                Console.WriteLine("(3) CX\n");

                                while (true)
                                {
                                    bool isNumber = int.TryParse(Console.ReadLine(),out int SelectedRegistryToMove);
                                    Console.WriteLine();

                                    if(isNumber) { 

                                        try
                                        {

                                            if (SelectedRegistryToMove == 1)

                                            {
                                                Console.Clear();
                                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                                Console.WriteLine("You have choosen AX registry, moving process is about to begin: \n");
                                                Console.ResetColor();

                                                Registries.AxValue = Registries.DxValue;
                                                Registries.AxToAddAndSub=Registries.DxToAddAndSub;
                                                Registries.AxValueStringOnly = Registries.DxValueStringOnly;
                                                Registries.DxToAddAndSub = 0;
                                                Registries.DxValue = 0.ToString();
                                                Registries.DxValueStringOnly = 0.ToString();

                                                PleaseWait.Wait();

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
                                                Registries.BxToAddAndSub = Registries.DxToAddAndSub;
                                                Registries.BxValueStringOnly = Registries.DxValueStringOnly;
                                                Registries.DxToAddAndSub = 0;
                                                Registries.DxValue = 0.ToString();
                                                Registries.DxValueStringOnly = 0.ToString();

                                                PleaseWait.Wait();

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
                                                Registries.CxToAddAndSub = Registries.DxToAddAndSub;
                                                Registries.CxValueStringOnly = Registries.DxValueStringOnly;
                                                Registries.DxToAddAndSub = 0;
                                                Registries.DxValue = 0.ToString();
                                                Registries.DxValueStringOnly = 0.ToString();

                                                PleaseWait.Wait();

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

                                    else 
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
