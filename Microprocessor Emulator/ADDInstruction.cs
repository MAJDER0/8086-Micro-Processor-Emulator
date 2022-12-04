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

                Console.WriteLine("(1) Add one registry value to another registry\n");
                Console.WriteLine("(2) Add value to choosen registry\n");
                Console.WriteLine("() Any key to return");

                int TriggerAction;

                int.TryParse(Console.ReadLine(), out TriggerAction);

                if (TriggerAction == 1)
                {

                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("Select registry you wanna add to another: \n");
                    Console.ResetColor();
                    Console.WriteLine("(1) AX\n");
                    Console.WriteLine("(2) BX\n");
                    Console.WriteLine("(3) CX\n");
                    Console.WriteLine("(4) DX\n");

                    int ChoosenRegistry;
                    int.TryParse(Console.ReadLine(), out ChoosenRegistry);


                    // -----------------------------------------------IF CHOOSEN REGISTRY IS AX------------------------------------------------------

                    if (ChoosenRegistry == 1)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine("You have choosen AX registry.Select registry you wanna add AX to: \n");
                        Console.ResetColor();

                        Console.WriteLine("(1) BX\n");
                        Console.WriteLine("(2) CX\n");
                        Console.WriteLine("(3) DX\n");

                        int.TryParse(Console.ReadLine(), out int SelectedRegistryToAdd);

                        if (SelectedRegistryToAdd == 1)
                        {

                            if (Registries.AxToAddAndSub != 0 && Registries.BxToAddAndSub != 0)
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                Console.WriteLine("\nYou have choosen BX Registry, adding process is about to begin");
                                Console.ResetColor();


                                if (Enumerable.Range(-32767, 65535).Contains((Registries.AxToAddAndSub + Registries.BxToAddAndSub)))
                                {
                                    Registries.BxValue = DecToHex.DecimalToHexadecimal((Registries.AxToAddAndSub + Registries.BxToAddAndSub));
                                    Registries.BxToAddAndSub += Registries.AxToAddAndSub;

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
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine("\nAfter Addition final number will exceed 16 bits. Please press any key to try again!");
                                    Console.ResetColor();
                                    Console.ReadLine();
                                    break;
                                }
                            }

                            if (Registries.AxToAddAndSub == 0 && Registries.BxToAddAndSub == 0)
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                Console.WriteLine("You have choosen BX Registry, adding process is about to begin");
                                Console.ResetColor();

                                string AddedValues = Registries.BxValue + Registries.AxValue;

                                bool isResultSixteenBits = ushort.TryParse(AddedValues, out ushort SixteenBitsResult);

                                if (isResultSixteenBits)
                                {

                                    Registries.BxValue = AddedValues;

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
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine("\nAfter Addition final number will exceed 16 bits. Please press any key to try again!");
                                    Console.ResetColor();
                                    Console.ReadLine();
                                    break;
                                }
                            }

                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("\nYou can't add word to number, please add number to number or word to word. Press any key to try again");
                                Console.ResetColor();
                                Console.ReadLine();
                                break;
                            }
                        }


                        if (SelectedRegistryToAdd == 2)
                        {

                            if (Registries.AxToAddAndSub != 0 && Registries.CxToAddAndSub != 0)
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                Console.WriteLine("\nYou have choosen CX Registry, adding process is about to begin");
                                Console.ResetColor();


                                if (Enumerable.Range(-32767, 65535).Contains((Registries.AxToAddAndSub + Registries.CxToAddAndSub)))
                                {
                                    Registries.CxValue = DecToHex.DecimalToHexadecimal((Registries.AxToAddAndSub + Registries.CxToAddAndSub));
                                    Registries.CxToAddAndSub += Registries.AxToAddAndSub;

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
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine("\nAfter Addition final number will exceed 16 bits. Please press any key to try again!");
                                    Console.ResetColor();
                                    Console.ReadLine();
                                    break;
                                }
                            }

                            if (Registries.AxToAddAndSub == 0 && Registries.CxToAddAndSub == 0)
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                Console.WriteLine("You have choosen CX Registry, adding process is about to begin");
                                Console.ResetColor();

                                string AddedValues = Registries.CxValue + Registries.AxValue;

                                bool isResultSixteenBits = ushort.TryParse(AddedValues, out ushort SixteenBitsResult);

                                if (isResultSixteenBits)
                                {

                                    Registries.CxValue = AddedValues;

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
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine("\nAfter Addition final number will exceed 16 bits. Please press any key to try again!");
                                    Console.ResetColor();
                                    Console.ReadLine();
                                    break;
                                }
                            }

                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("\nYou can't add word to number, please add number to number or word to word. Press any key to try again");
                                Console.ResetColor();
                                Console.ReadLine();
                                break;
                            }
                        }


                        if (SelectedRegistryToAdd == 3)
                        {

                            if (Registries.AxToAddAndSub != 0 && Registries.DxToAddAndSub != 0)
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                Console.WriteLine("\nYou have choosen DX Registry, adding process is about to begin");
                                Console.ResetColor();


                                if (Enumerable.Range(-32767, 65535).Contains((Registries.AxToAddAndSub + Registries.DxToAddAndSub)))
                                {
                                    Registries.DxValue = DecToHex.DecimalToHexadecimal((Registries.AxToAddAndSub + Registries.DxToAddAndSub));
                                    Registries.DxToAddAndSub += Registries.AxToAddAndSub;

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
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine("\nAfter Addition final number will exceed 16 bits. Please press any key to try again!");
                                    Console.ResetColor();
                                    Console.ReadLine();
                                    break;
                                }
                            }

                            if (Registries.AxToAddAndSub == 0 && Registries.DxToAddAndSub == 0)
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                Console.WriteLine("You have choosen DX Registry, adding process is about to begin");
                                Console.ResetColor();

                                string AddedValues = Registries.DxValue + Registries.AxValue;

                                bool isResultSixteenBits = ushort.TryParse(AddedValues, out ushort SixteenBitsResult);

                                if (isResultSixteenBits)
                                {

                                    Registries.DxValue = AddedValues;

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
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine("\nAfter Addition final number will exceed 16 bits. Please press any key to try again!");
                                    Console.ResetColor();
                                    Console.ReadLine();
                                    break;
                                }
                            }

                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("\nYou can't add word to number, please add number to number or word to word. Press any key to try again");
                                Console.ResetColor();
                                Console.ReadLine();
                                break;
                            }
                        }


                    }

                    //---------------------------------------------IF CHOOSEN REGISTRY IS BX----------------------------------------------------------

                    if (ChoosenRegistry == 2)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine("You have choosen BX registry.Select registry you wanna add BX to: \n");
                        Console.ResetColor();

                        Console.WriteLine("(1) AX\n");
                        Console.WriteLine("(2) CX\n");
                        Console.WriteLine("(3) DX\n");

                        int.TryParse(Console.ReadLine(), out int SelectedRegistryToAdd);

                        if (SelectedRegistryToAdd == 1)
                        {

                            if (Registries.BxToAddAndSub != 0 && Registries.AxToAddAndSub != 0)
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                Console.WriteLine("\nYou have choosen AX Registry, adding process is about to begin");
                                Console.ResetColor();


                                if (Enumerable.Range(-32767, 65535).Contains((Registries.BxToAddAndSub + Registries.AxToAddAndSub)))
                                {
                                    Registries.AxValue = DecToHex.DecimalToHexadecimal((Registries.BxToAddAndSub + Registries.AxToAddAndSub));
                                    Registries.AxToAddAndSub += Registries.BxToAddAndSub;

                                    Console.WriteLine("\nPlease wait. . .");
                                    System.Threading.Thread.Sleep(1000);
                                    Console.WriteLine("Please wait. . .");
                                    System.Threading.Thread.Sleep(1000);
                                    Console.WriteLine("Please wait. . .");
                                    System.Threading.Thread.Sleep(1000);



                                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                                    Console.WriteLine("\nSuccess! BX registry value has been successfully added to AX registry value. Press any key to return.");
                                    Console.ResetColor();
                                    Console.ReadLine();
                                    Program.Main();
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine("\nAfter Addition final number will exceed 16 bits. Please press any key to try again!");
                                    Console.ResetColor();
                                    Console.ReadLine();
                                    break;
                                }
                            }

                            if (Registries.BxToAddAndSub == 0 && Registries.AxToAddAndSub == 0)
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                Console.WriteLine("You have choosen AX Registry, adding process is about to begin");
                                Console.ResetColor();

                                string AddedValues = Registries.AxValue + Registries.BxValue;

                                bool isResultSixteenBits = ushort.TryParse(AddedValues, out ushort SixteenBitsResult);

                                if (isResultSixteenBits)
                                {

                                    Registries.AxValue = AddedValues;

                                    Console.WriteLine("\nPlease wait. . .");
                                    System.Threading.Thread.Sleep(1000);
                                    Console.WriteLine("Please wait. . .");
                                    System.Threading.Thread.Sleep(1000);
                                    Console.WriteLine("Please wait. . .");
                                    System.Threading.Thread.Sleep(1000);

                                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                                    Console.WriteLine("\nSuccess! BX registry value has been successfully added to AX registry value. Press any key to return.");
                                    Console.ResetColor();
                                    Console.ReadLine();
                                    Program.Main();
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine("\nAfter Addition final number will exceed 16 bits. Please press any key to try again!");
                                    Console.ResetColor();
                                    Console.ReadLine();
                                    break;
                                }
                            }

                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("\nYou can't add word to number, please add number to number or word to word. Press any key to try again");
                                Console.ResetColor();
                                Console.ReadLine();
                                break;
                            }
                        }


                        if (SelectedRegistryToAdd == 2)
                        {

                            if (Registries.BxToAddAndSub != 0 && Registries.CxToAddAndSub != 0)
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                Console.WriteLine("\nYou have choosen CX Registry, adding process is about to begin");
                                Console.ResetColor();


                                if (Enumerable.Range(-32767, 65535).Contains((Registries.BxToAddAndSub + Registries.CxToAddAndSub)))
                                {
                                    Registries.CxValue = DecToHex.DecimalToHexadecimal((Registries.BxToAddAndSub + Registries.CxToAddAndSub));
                                    Registries.CxToAddAndSub += Registries.BxToAddAndSub;

                                    Console.WriteLine("\nPlease wait. . .");
                                    System.Threading.Thread.Sleep(1000);
                                    Console.WriteLine("Please wait. . .");
                                    System.Threading.Thread.Sleep(1000);
                                    Console.WriteLine("Please wait. . .");
                                    System.Threading.Thread.Sleep(1000);



                                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                                    Console.WriteLine("\nSuccess! BX registry value has been successfully added to CX registry value. Press any key to return.");
                                    Console.ResetColor();
                                    Console.ReadLine();
                                    Program.Main();
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine("\nAfter Addition final number will exceed 16 bits. Please press any key to try again!");
                                    Console.ResetColor();
                                    Console.ReadLine();
                                    break;
                                }
                            }

                            if (Registries.BxToAddAndSub == 0 && Registries.CxToAddAndSub == 0)
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                Console.WriteLine("You have choosen CX Registry, adding process is about to begin");
                                Console.ResetColor();

                                string AddedValues = Registries.CxValue + Registries.BxValue;

                                bool isResultSixteenBits = ushort.TryParse(AddedValues, out ushort SixteenBitsResult);

                                if (isResultSixteenBits)
                                {

                                    Registries.CxValue = AddedValues;

                                    Console.WriteLine("\nPlease wait. . .");
                                    System.Threading.Thread.Sleep(1000);
                                    Console.WriteLine("Please wait. . .");
                                    System.Threading.Thread.Sleep(1000);
                                    Console.WriteLine("Please wait. . .");
                                    System.Threading.Thread.Sleep(1000);

                                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                                    Console.WriteLine("\nSuccess! BX registry value has been successfully added to CX registry value. Press any key to return.");
                                    Console.ResetColor();
                                    Console.ReadLine();
                                    Program.Main();
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine("\nAfter Addition final number will exceed 16 bits. Please press any key to try again!");
                                    Console.ResetColor();
                                    Console.ReadLine();
                                    break;
                                }
                            }

                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("\nYou can't add word to number, please add number to number or word to word. Press any key to try again");
                                Console.ResetColor();
                                Console.ReadLine();
                                break;
                            }
                        }


                        if (SelectedRegistryToAdd == 3)
                        {

                            if (Registries.BxToAddAndSub != 0 && Registries.DxToAddAndSub != 0)
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                Console.WriteLine("\nYou have choosen DX Registry, adding process is about to begin");
                                Console.ResetColor();


                                if (Enumerable.Range(-32767, 65535).Contains((Registries.BxToAddAndSub + Registries.DxToAddAndSub)))
                                {
                                    Registries.DxValue = DecToHex.DecimalToHexadecimal((Registries.BxToAddAndSub + Registries.DxToAddAndSub));
                                    Registries.DxToAddAndSub += Registries.BxToAddAndSub;

                                    Console.WriteLine("\nPlease wait. . .");
                                    System.Threading.Thread.Sleep(1000);
                                    Console.WriteLine("Please wait. . .");
                                    System.Threading.Thread.Sleep(1000);
                                    Console.WriteLine("Please wait. . .");
                                    System.Threading.Thread.Sleep(1000);



                                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                                    Console.WriteLine("\nSuccess! BX registry value has been successfully added to DX registry value. Press any key to return.");
                                    Console.ResetColor();
                                    Console.ReadLine();
                                    Program.Main();
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine("\nAfter Addition final number will exceed 16 bits. Please press any key to try again!");
                                    Console.ResetColor();
                                    Console.ReadLine();
                                    break;
                                }
                            }

                            if (Registries.BxToAddAndSub == 0 && Registries.DxToAddAndSub == 0)
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                Console.WriteLine("You have choosen DX Registry, adding process is about to begin");
                                Console.ResetColor();

                                string AddedValues = Registries.DxValue + Registries.BxValue;

                                bool isResultSixteenBits = ushort.TryParse(AddedValues, out ushort SixteenBitsResult);

                                if (isResultSixteenBits)
                                {

                                    Registries.DxValue = AddedValues;

                                    Console.WriteLine("\nPlease wait. . .");
                                    System.Threading.Thread.Sleep(1000);
                                    Console.WriteLine("Please wait. . .");
                                    System.Threading.Thread.Sleep(1000);
                                    Console.WriteLine("Please wait. . .");
                                    System.Threading.Thread.Sleep(1000);

                                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                                    Console.WriteLine("\nSuccess! BX registry value has been successfully added to DX registry value. Press any key to return.");
                                    Console.ResetColor();
                                    Console.ReadLine();
                                    Program.Main();
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine("\nAfter Addition final number will exceed 16 bits. Please press any key to try again!");
                                    Console.ResetColor();
                                    Console.ReadLine();
                                    break;
                                }
                            }

                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("\nYou can't add word to number, please add number to number or word to word. Press any key to try again");
                                Console.ResetColor();
                                Console.ReadLine();
                                break;
                            }
                        }


                    }


                    //---------------------------------------------IF CHOOSEN REGISTRY IS CX----------------------------------------------------------


                    if (ChoosenRegistry == 3)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine("You have choosen CX registry.Select registry you wanna add CX to: \n");
                        Console.ResetColor();

                        Console.WriteLine("(1) AX\n");
                        Console.WriteLine("(2) BX\n");
                        Console.WriteLine("(3) DX\n");

                        int.TryParse(Console.ReadLine(), out int SelectedRegistryToAdd);

                        if (SelectedRegistryToAdd == 1)
                        {

                            if (Registries.CxToAddAndSub != 0 && Registries.AxToAddAndSub != 0)
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                Console.WriteLine("\nYou have choosen AX Registry, adding process is about to begin");
                                Console.ResetColor();


                                if (Enumerable.Range(-32767, 65535).Contains((Registries.CxToAddAndSub + Registries.AxToAddAndSub)))
                                {
                                    Registries.AxValue = DecToHex.DecimalToHexadecimal((Registries.CxToAddAndSub + Registries.AxToAddAndSub));
                                    Registries.AxToAddAndSub += Registries.CxToAddAndSub;

                                    Console.WriteLine("\nPlease wait. . .");
                                    System.Threading.Thread.Sleep(1000);
                                    Console.WriteLine("Please wait. . .");
                                    System.Threading.Thread.Sleep(1000);
                                    Console.WriteLine("Please wait. . .");
                                    System.Threading.Thread.Sleep(1000);



                                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                                    Console.WriteLine("\nSuccess! CX registry value has been successfully added to AX registry value. Press any key to return.");
                                    Console.ResetColor();
                                    Console.ReadLine();
                                    Program.Main();
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine("\nAfter Addition final number will exceed 16 bits. Please press any key to try again!");
                                    Console.ResetColor();
                                    Console.ReadLine();
                                    break;
                                }
                            }

                            if (Registries.CxToAddAndSub == 0 && Registries.AxToAddAndSub == 0)
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                Console.WriteLine("You have choosen AX Registry, adding process is about to begin");
                                Console.ResetColor();

                                string AddedValues = Registries.AxValue + Registries.CxValue;

                                bool isResultSixteenBits = ushort.TryParse(AddedValues, out ushort SixteenBitsResult);

                                if (isResultSixteenBits)
                                {

                                    Registries.AxValue = AddedValues;

                                    Console.WriteLine("\nPlease wait. . .");
                                    System.Threading.Thread.Sleep(1000);
                                    Console.WriteLine("Please wait. . .");
                                    System.Threading.Thread.Sleep(1000);
                                    Console.WriteLine("Please wait. . .");
                                    System.Threading.Thread.Sleep(1000);

                                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                                    Console.WriteLine("\nSuccess! CX registry value has been successfully added to AX registry value. Press any key to return.");
                                    Console.ResetColor();
                                    Console.ReadLine();
                                    Program.Main();
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine("\nAfter Addition final number will exceed 16 bits. Please press any key to try again!");
                                    Console.ResetColor();
                                    Console.ReadLine();
                                    break;
                                }
                            }

                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("\nYou can't add word to number, please add number to number or word to word. Press any key to try again");
                                Console.ResetColor();
                                Console.ReadLine();
                                break;
                            }
                        }


                        if (SelectedRegistryToAdd == 2)
                        {

                            if (Registries.BxToAddAndSub != 0 && Registries.CxToAddAndSub != 0)
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                Console.WriteLine("\nYou have choosen BX Registry, adding process is about to begin");
                                Console.ResetColor();


                                if (Enumerable.Range(-32767, 65535).Contains((Registries.BxToAddAndSub + Registries.CxToAddAndSub)))
                                {
                                    Registries.BxValue = DecToHex.DecimalToHexadecimal((Registries.BxToAddAndSub + Registries.CxToAddAndSub));
                                    Registries.BxToAddAndSub += Registries.CxToAddAndSub;

                                    Console.WriteLine("\nPlease wait. . .");
                                    System.Threading.Thread.Sleep(1000);
                                    Console.WriteLine("Please wait. . .");
                                    System.Threading.Thread.Sleep(1000);
                                    Console.WriteLine("Please wait. . .");
                                    System.Threading.Thread.Sleep(1000);



                                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                                    Console.WriteLine("\nSuccess! CX registry value has been successfully added to BX registry value. Press any key to return.");
                                    Console.ResetColor();
                                    Console.ReadLine();
                                    Program.Main();
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine("\nAfter Addition final number will exceed 16 bits. Please press any key to try again!");
                                    Console.ResetColor();
                                    Console.ReadLine();
                                    break;
                                }
                            }

                            if (Registries.BxToAddAndSub == 0 && Registries.CxToAddAndSub == 0)
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                Console.WriteLine("You have choosen BX Registry, adding process is about to begin");
                                Console.ResetColor();

                                string AddedValues = Registries.CxValue + Registries.BxValue;

                                bool isResultSixteenBits = ushort.TryParse(AddedValues, out ushort SixteenBitsResult);

                                if (isResultSixteenBits)
                                {

                                    Registries.BxValue = AddedValues;

                                    Console.WriteLine("\nPlease wait. . .");
                                    System.Threading.Thread.Sleep(1000);
                                    Console.WriteLine("Please wait. . .");
                                    System.Threading.Thread.Sleep(1000);
                                    Console.WriteLine("Please wait. . .");
                                    System.Threading.Thread.Sleep(1000);

                                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                                    Console.WriteLine("\nSuccess! CX registry value has been successfully added to BX registry value. Press any key to return.");
                                    Console.ResetColor();
                                    Console.ReadLine();
                                    Program.Main();
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine("\nAfter Addition final number will exceed 16 bits. Please press any key to try again!");
                                    Console.ResetColor();
                                    Console.ReadLine();
                                    break;
                                }
                            }

                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("\nYou can't add word to number, please add number to number or word to word. Press any key to try again");
                                Console.ResetColor();
                                Console.ReadLine();
                                break;
                            }
                        }


                        if (SelectedRegistryToAdd == 3)
                        {

                            if (Registries.CxToAddAndSub != 0 && Registries.DxToAddAndSub != 0)
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                Console.WriteLine("\nYou have choosen DX Registry, adding process is about to begin");
                                Console.ResetColor();


                                if (Enumerable.Range(-32767, 65535).Contains((Registries.CxToAddAndSub + Registries.DxToAddAndSub)))
                                {
                                    Registries.DxValue = DecToHex.DecimalToHexadecimal((Registries.CxToAddAndSub + Registries.DxToAddAndSub));
                                    Registries.DxToAddAndSub += Registries.CxToAddAndSub;

                                    Console.WriteLine("\nPlease wait. . .");
                                    System.Threading.Thread.Sleep(1000);
                                    Console.WriteLine("Please wait. . .");
                                    System.Threading.Thread.Sleep(1000);
                                    Console.WriteLine("Please wait. . .");
                                    System.Threading.Thread.Sleep(1000);



                                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                                    Console.WriteLine("\nSuccess! CX registry value has been successfully added to DX registry value. Press any key to return.");
                                    Console.ResetColor();
                                    Console.ReadLine();
                                    Program.Main();
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine("\nAfter Addition final number will exceed 16 bits. Please press any key to try again!");
                                    Console.ResetColor();
                                    Console.ReadLine();
                                    break;
                                }
                            }

                            if (Registries.CxToAddAndSub == 0 && Registries.DxToAddAndSub == 0)
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                Console.WriteLine("You have choosen DX Registry, adding process is about to begin");
                                Console.ResetColor();

                                string AddedValues = Registries.DxValue + Registries.CxValue;

                                bool isResultSixteenBits = ushort.TryParse(AddedValues, out ushort SixteenBitsResult);

                                if (isResultSixteenBits)
                                {

                                    Registries.DxValue = AddedValues;

                                    Console.WriteLine("\nPlease wait. . .");
                                    System.Threading.Thread.Sleep(1000);
                                    Console.WriteLine("Please wait. . .");
                                    System.Threading.Thread.Sleep(1000);
                                    Console.WriteLine("Please wait. . .");
                                    System.Threading.Thread.Sleep(1000);

                                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                                    Console.WriteLine("\nSuccess! CX registry value has been successfully added to DX registry value. Press any key to return.");
                                    Console.ResetColor();
                                    Console.ReadLine();
                                    Program.Main();
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine("\nAfter Addition final number will exceed 16 bits. Please press any key to try again!");
                                    Console.ResetColor();
                                    Console.ReadLine();
                                    break;
                                }
                            }

                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("\nYou can't add word to number, please add number to number or word to word. Press any key to try again");
                                Console.ResetColor();
                                Console.ReadLine();
                                break;
                            }
                        }


                    }


                    //---------------------------------------------IF CHOOSEN REGISTRY IS DX----------------------------------------------------------

                    if (ChoosenRegistry == 4)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine("You have choosen DX registry.Select registry you wanna add DX to: \n");
                        Console.ResetColor();

                        Console.WriteLine("(1) AX\n");
                        Console.WriteLine("(2) BX\n");
                        Console.WriteLine("(3) CX\n");

                        int.TryParse(Console.ReadLine(), out int SelectedRegistryToAdd);

                        if (SelectedRegistryToAdd == 1)
                        {

                            if (Registries.DxToAddAndSub != 0 && Registries.AxToAddAndSub != 0)
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                Console.WriteLine("\nYou have choosen AX Registry, adding process is about to begin");
                                Console.ResetColor();


                                if (Enumerable.Range(-32767, 65535).Contains((Registries.DxToAddAndSub + Registries.AxToAddAndSub)))
                                {
                                    Registries.AxValue = DecToHex.DecimalToHexadecimal((Registries.DxToAddAndSub + Registries.AxToAddAndSub));
                                    Registries.AxToAddAndSub += Registries.DxToAddAndSub;

                                    Console.WriteLine("\nPlease wait. . .");
                                    System.Threading.Thread.Sleep(1000);
                                    Console.WriteLine("Please wait. . .");
                                    System.Threading.Thread.Sleep(1000);
                                    Console.WriteLine("Please wait. . .");
                                    System.Threading.Thread.Sleep(1000);



                                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                                    Console.WriteLine("\nSuccess! DX registry value has been successfully added to AX registry value. Press any key to return.");
                                    Console.ResetColor();
                                    Console.ReadLine();
                                    Program.Main();
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine("\nAfter Addition final number will exceed 16 bits. Please press any key to try again!");
                                    Console.ResetColor();
                                    Console.ReadLine();
                                    break;
                                }
                            }

                            if (Registries.DxToAddAndSub == 0 && Registries.AxToAddAndSub == 0)
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                Console.WriteLine("You have choosen AX Registry, adding process is about to begin");
                                Console.ResetColor();

                                string AddedValues = Registries.AxValue + Registries.DxValue;

                                bool isResultSixteenBits = ushort.TryParse(AddedValues, out ushort SixteenBitsResult);

                                if (isResultSixteenBits)
                                {

                                    Registries.AxValue = AddedValues;

                                    Console.WriteLine("\nPlease wait. . .");
                                    System.Threading.Thread.Sleep(1000);
                                    Console.WriteLine("Please wait. . .");
                                    System.Threading.Thread.Sleep(1000);
                                    Console.WriteLine("Please wait. . .");
                                    System.Threading.Thread.Sleep(1000);

                                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                                    Console.WriteLine("\nSuccess! DX registry value has been successfully added to AX registry value. Press any key to return.");
                                    Console.ResetColor();
                                    Console.ReadLine();
                                    Program.Main();
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine("\nAfter Addition final number will exceed 16 bits. Please press any key to try again!");
                                    Console.ResetColor();
                                    Console.ReadLine();
                                    break;
                                }
                            }

                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("\nYou can't add word to number, please add number to number or word to word. Press any key to try again");
                                Console.ResetColor();
                                Console.ReadLine();
                                break;
                            }
                        }


                        if (SelectedRegistryToAdd == 2)
                        {

                            if (Registries.BxToAddAndSub != 0 && Registries.DxToAddAndSub != 0)
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                Console.WriteLine("\nYou have choosen BX Registry, adding process is about to begin");
                                Console.ResetColor();


                                if (Enumerable.Range(-32767, 65535).Contains((Registries.BxToAddAndSub + Registries.DxToAddAndSub)))
                                {
                                    Registries.BxValue = DecToHex.DecimalToHexadecimal((Registries.BxToAddAndSub + Registries.DxToAddAndSub));
                                    Registries.BxToAddAndSub += Registries.DxToAddAndSub;

                                    Console.WriteLine("\nPlease wait. . .");
                                    System.Threading.Thread.Sleep(1000);
                                    Console.WriteLine("Please wait. . .");
                                    System.Threading.Thread.Sleep(1000);
                                    Console.WriteLine("Please wait. . .");
                                    System.Threading.Thread.Sleep(1000);



                                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                                    Console.WriteLine("\nSuccess! DX registry value has been successfully added to BX registry value. Press any key to return.");
                                    Console.ResetColor();
                                    Console.ReadLine();
                                    Program.Main();
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine("\nAfter Addition final number will exceed 16 bits. Please press any key to try again!");
                                    Console.ResetColor();
                                    Console.ReadLine();
                                    break;
                                }
                            }

                            if (Registries.BxToAddAndSub == 0 && Registries.DxToAddAndSub == 0)
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                Console.WriteLine("You have choosen BX Registry, adding process is about to begin");
                                Console.ResetColor();

                                string AddedValues = Registries.DxValue + Registries.BxValue;

                                bool isResultSixteenBits = ushort.TryParse(AddedValues, out ushort SixteenBitsResult);

                                if (isResultSixteenBits)
                                {

                                    Registries.BxValue = AddedValues;

                                    Console.WriteLine("\nPlease wait. . .");
                                    System.Threading.Thread.Sleep(1000);
                                    Console.WriteLine("Please wait. . .");
                                    System.Threading.Thread.Sleep(1000);
                                    Console.WriteLine("Please wait. . .");
                                    System.Threading.Thread.Sleep(1000);

                                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                                    Console.WriteLine("\nSuccess! DX registry value has been successfully added to BX registry value. Press any key to return.");
                                    Console.ResetColor();
                                    Console.ReadLine();
                                    Program.Main();
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine("\nAfter Addition final number will exceed 16 bits. Please press any key to try again!");
                                    Console.ResetColor();
                                    Console.ReadLine();
                                    break;
                                }
                            }

                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("\nYou can't add word to number, please add number to number or word to word. Press any key to try again");
                                Console.ResetColor();
                                Console.ReadLine();
                                break;
                            }
                        }


                        if (SelectedRegistryToAdd == 3)
                        {

                            if (Registries.CxToAddAndSub != 0 && Registries.DxToAddAndSub != 0)
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                Console.WriteLine("\nYou have choosen CX Registry, adding process is about to begin");
                                Console.ResetColor();


                                if (Enumerable.Range(-32767, 65535).Contains((Registries.CxToAddAndSub + Registries.DxToAddAndSub)))
                                {
                                    Registries.CxValue = DecToHex.DecimalToHexadecimal((Registries.CxToAddAndSub + Registries.DxToAddAndSub));
                                    Registries.CxToAddAndSub += Registries.DxToAddAndSub;

                                    Console.WriteLine("\nPlease wait. . .");
                                    System.Threading.Thread.Sleep(1000);
                                    Console.WriteLine("Please wait. . .");
                                    System.Threading.Thread.Sleep(1000);
                                    Console.WriteLine("Please wait. . .");
                                    System.Threading.Thread.Sleep(1000);



                                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                                    Console.WriteLine("\nSuccess! DX registry value has been successfully added to CX registry value. Press any key to return.");
                                    Console.ResetColor();
                                    Console.ReadLine();
                                    Program.Main();
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine("\nAfter Addition final number will exceed 16 bits. Please press any key to try again!");
                                    Console.ResetColor();
                                    Console.ReadLine();
                                    break;
                                }
                            }

                            if (Registries.CxToAddAndSub == 0 && Registries.DxToAddAndSub == 0)
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                Console.WriteLine("You have choosen CX Registry, adding process is about to begin");
                                Console.ResetColor();

                                string AddedValues = Registries.DxValue + Registries.CxValue;

                                bool isResultSixteenBits = ushort.TryParse(AddedValues, out ushort SixteenBitsResult);

                                if (isResultSixteenBits)
                                {

                                    Registries.CxValue = AddedValues;

                                    Console.WriteLine("\nPlease wait. . .");
                                    System.Threading.Thread.Sleep(1000);
                                    Console.WriteLine("Please wait. . .");
                                    System.Threading.Thread.Sleep(1000);
                                    Console.WriteLine("Please wait. . .");
                                    System.Threading.Thread.Sleep(1000);

                                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                                    Console.WriteLine("\nSuccess! DX registry value has been successfully added to CX registry value. Press any key to return.");
                                    Console.ResetColor();
                                    Console.ReadLine();
                                    Program.Main();
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine("\nAfter Addition final number will exceed 16 bits. Please press any key to try again!");
                                    Console.ResetColor();
                                    Console.ReadLine();
                                    break;
                                }
                            }

                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("\nYou can't add word to number, please add number to number or word to word. Press any key to try again");
                                Console.ResetColor();
                                Console.ReadLine();
                                break;
                            }
                        }
                    }
                }
                //---------------------------------------------------------------------------------------------------------------
                if (TriggerAction == 2)
                {
                    Console.WriteLine("");
                }

                else
                {
                    break;
                }
            }
        }
    }

}

