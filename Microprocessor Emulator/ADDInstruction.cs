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
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("What would you like to add?\n");
                Console.ResetColor();

                Console.WriteLine("(1) Add one registry value to another registry\n");
                Console.WriteLine("(2) Add number or string to choosen registry\n");
                Console.WriteLine("() Any key to return\n");

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

                                    PleaseWait.Wait();

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

                            if (Registries.AxToAddAndSub == 0 && Registries.BxToAddAndSub == 0 && Registries.AxValueStringOnly != 0.ToString() && Registries.BxValueStringOnly != 0.ToString())
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                Console.WriteLine("You have choosen BX Registry, adding process is about to begin");
                                Console.ResetColor();

                                string AddedValues = Registries.AxValueStringOnly + Registries.BxValueStringOnly;

                                int counter = 0;

                                foreach (var item in AddedValues)
                                {
                                    counter++;
                                }

                                if (counter < 16)
                                {

                                    Registries.BxValue = AddedValues;
                                    Registries.BxValueStringOnly = AddedValues;

                                    PleaseWait.Wait();

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

                            if (Registries.AxToAddAndSub == 0 && Registries.BxToAddAndSub == 0 && Registries.AxValueStringOnly == 0.ToString() && Registries.BxValueStringOnly == 0.ToString())
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

                                    PleaseWait.Wait();

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
                                Console.WriteLine("\nYou can't add string-to-number, number-to-string or string stored as bit of informations (SABOI) to casual string or number. Please add number-to-number, string-to-string or (SABI)string-to-(SABI)string. Press any key to try again");
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

                                    PleaseWait.Wait();

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

                            if (Registries.AxToAddAndSub == 0 && Registries.CxToAddAndSub == 0 && Registries.AxValueStringOnly != 0.ToString() && Registries.CxValueStringOnly != 0.ToString())
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                Console.WriteLine("You have choosen CX Registry, adding process is about to begin");
                                Console.ResetColor();

                                string AddedValues = Registries.AxValueStringOnly + Registries.CxValueStringOnly;

                                int counter = 0;

                                foreach (var item in AddedValues)
                                {
                                    counter++;
                                }

                                if (counter < 16)
                                {
                                    Registries.CxValue = AddedValues;
                                    Registries.CxValueStringOnly = AddedValues;

                                    PleaseWait.Wait();

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

                            if (Registries.AxToAddAndSub == 0 && Registries.CxToAddAndSub == 0 && Registries.AxValueStringOnly == 0.ToString() && Registries.CxValueStringOnly == 0.ToString())
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

                                    PleaseWait.Wait();

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
                                Console.WriteLine("\nYou can't add string-to-number, number-to-string or string stored as bit of informations (SABOI) to casual string or number. Please add number-to-number, string-to-string or (SABI)string-to-(SABI)string. Press any key to try again");
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

                                    PleaseWait.Wait();

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
                            if (Registries.AxToAddAndSub == 0 && Registries.DxToAddAndSub == 0 && Registries.AxValueStringOnly != 0.ToString() && Registries.DxValueStringOnly != 0.ToString())
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                Console.WriteLine("You have choosen DX Registry, adding process is about to begin");
                                Console.ResetColor();

                                string AddedValues = Registries.AxValueStringOnly + Registries.DxValueStringOnly;

                                int counter = 0;

                                foreach (var item in AddedValues)
                                {
                                    counter++;
                                }

                                if (counter < 16)
                                {

                                    Registries.DxValue = AddedValues;
                                    Registries.DxValueStringOnly = AddedValues;

                                    PleaseWait.Wait();

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

                            if (Registries.AxToAddAndSub == 0 && Registries.DxToAddAndSub == 0 && Registries.AxValueStringOnly == 0.ToString() && Registries.DxValueStringOnly == 0.ToString())
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

                                    PleaseWait.Wait();

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
                                Console.WriteLine("\nYou can't add string-to-number, number-to-string or string stored as bit of informations (SABOI) to casual string or number. Please add number-to-number, string-to-string or (SABI)string-to-(SABI)string. Press any key to try again");
                                Console.ResetColor();
                                Console.ReadLine();
                                break;
                            }
                        }


                    }

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

                                    PleaseWait.Wait();

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

                            if (Registries.BxToAddAndSub == 0 && Registries.AxToAddAndSub == 0 && Registries.BxValueStringOnly != 0.ToString() && Registries.AxValueStringOnly != 0.ToString())
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                Console.WriteLine("You have choosen AX Registry, adding process is about to begin");
                                Console.ResetColor();

                                string AddedValues = Registries.AxValueStringOnly + Registries.BxValueStringOnly;

                                int counter = 0;

                                foreach (var item in AddedValues)
                                {
                                    counter++;
                                }

                                if (counter < 16)
                                {
                                    Registries.BxValue = AddedValues;
                                    Registries.BxValueStringOnly = AddedValues;

                                    PleaseWait.Wait();

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

                            if (Registries.BxToAddAndSub == 0 && Registries.AxToAddAndSub == 0 && Registries.BxValueStringOnly == 0.ToString() && Registries.AxValueStringOnly == 0.ToString())
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

                                    PleaseWait.Wait();

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
                                Console.WriteLine("\nYou can't add string-to-number, number-to-string or string stored as bit of informations (SABOI) to casual string or number. Please add number-to-number, string-to-string or (SABI)string-to-(SABI)string. Press any key to try again");
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

                                    PleaseWait.Wait();

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

                            if (Registries.BxToAddAndSub == 0 && Registries.CxToAddAndSub == 0 && Registries.BxValueStringOnly != 0.ToString() && Registries.CxValueStringOnly != 0.ToString())
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                Console.WriteLine("You have choosen CX Registry, adding process is about to begin");
                                Console.ResetColor();

                                string AddedValues = Registries.BxValueStringOnly + Registries.CxValueStringOnly;

                                int counter = 0;

                                foreach (var item in AddedValues)
                                {
                                    counter++;
                                }

                                if (counter < 16)
                                {

                                    Registries.CxValue = AddedValues;
                                    Registries.CxValueStringOnly = AddedValues;

                                    PleaseWait.Wait();

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

                            if (Registries.BxToAddAndSub == 0 && Registries.CxToAddAndSub == 0 && Registries.BxValueStringOnly == 0.ToString() && Registries.CxValueStringOnly == 0.ToString())
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

                                    PleaseWait.Wait();

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
                                Console.WriteLine("\nYou can't add string-to-number, number-to-string or string stored as bit of informations (SABOI) to casual string or number. Please add number-to-number, string-to-string or (SABI)string-to-(SABI)string. Press any key to try again");
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

                                    PleaseWait.Wait();

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

                            if (Registries.BxToAddAndSub == 0 && Registries.DxToAddAndSub == 0 && Registries.BxValueStringOnly != 0.ToString() && Registries.DxValueStringOnly != 0.ToString())
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                Console.WriteLine("You have choosen DX Registry, adding process is about to begin");
                                Console.ResetColor();

                                string AddedValues = Registries.BxValueStringOnly + Registries.DxValueStringOnly;

                                int counter = 0;

                                foreach (var item in AddedValues)
                                {
                                    counter++;
                                }

                                if (counter < 16)
                                {

                                    Registries.DxValue = AddedValues;
                                    Registries.DxValueStringOnly = AddedValues;

                                    PleaseWait.Wait();

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

                            if (Registries.BxToAddAndSub == 0 && Registries.DxToAddAndSub == 0 && Registries.BxValueStringOnly == 0.ToString() && Registries.DxValueStringOnly == 0.ToString())
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

                                    PleaseWait.Wait();

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
                                Console.WriteLine("\nYou can't add string-to-number, number-to-string or string stored as bit of informations (SABOI) to casual string or number. Please add number-to-number, string-to-string or (SABI)string-to-(SABI)string. Press any key to try again");
                                Console.ResetColor();
                                Console.ReadLine();
                                break;
                            }
                        }


                    }

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

                                    PleaseWait.Wait();

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

                            if (Registries.CxToAddAndSub == 0 && Registries.AxToAddAndSub == 0 && Registries.CxValueStringOnly != 0.ToString() && Registries.AxValueStringOnly != 0.ToString())
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                Console.WriteLine("You have choosen AX Registry, adding process is about to begin");
                                Console.ResetColor();

                                string AddedValues = Registries.CxValueStringOnly + Registries.AxValueStringOnly;

                                int counter = 0;

                                foreach (var item in AddedValues)
                                {
                                    counter++;
                                }

                                if (counter < 16)
                                {

                                    Registries.AxValue = AddedValues;
                                    Registries.AxValueStringOnly = AddedValues;

                                    PleaseWait.Wait();

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

                            if (Registries.CxToAddAndSub == 0 && Registries.AxToAddAndSub == 0 && Registries.CxValueStringOnly == 0.ToString() && Registries.AxValueStringOnly == 0.ToString())
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

                                    PleaseWait.Wait();

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
                                Console.WriteLine("\nYou can't add string-to-number, number-to-string or string stored as bit of informations (SABOI) to casual string or number. Please add number-to-number, string-to-string or (SABI)string-to-(SABI)string. Press any key to try again");
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

                                    PleaseWait.Wait();



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

                            if (Registries.CxToAddAndSub == 0 && Registries.BxToAddAndSub == 0 && Registries.CxValueStringOnly != 0.ToString() && Registries.BxValueStringOnly != 0.ToString())
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                Console.WriteLine("You have choosen BX Registry, adding process is about to begin");
                                Console.ResetColor();

                                string AddedValues = Registries.CxValueStringOnly + Registries.BxValueStringOnly;

                                int counter = 0;

                                foreach (var item in AddedValues)
                                {
                                    counter++;
                                }

                                if (counter < 16)
                                {

                                    Registries.BxValue = AddedValues;
                                    Registries.BxValueStringOnly = AddedValues;

                                    PleaseWait.Wait();

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

                            if (Registries.CxToAddAndSub == 0 && Registries.BxToAddAndSub == 0 && Registries.CxValueStringOnly == 0.ToString() && Registries.BxValueStringOnly == 0.ToString())
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

                                    PleaseWait.Wait();

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
                                Console.WriteLine("\nYou can't add string-to-number, number-to-string or string stored as bit of informations (SABOI) to casual string or number. Please add number-to-number, string-to-string or (SABI)string-to-(SABI)string. Press any key to try again");
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

                                    PleaseWait.Wait();



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

                            if (Registries.CxToAddAndSub == 0 && Registries.DxToAddAndSub == 0 && Registries.CxValueStringOnly != 0.ToString() && Registries.DxValueStringOnly != 0.ToString())
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                Console.WriteLine("You have choosen DX Registry, adding process is about to begin");
                                Console.ResetColor();

                                string AddedValues = Registries.CxValueStringOnly + Registries.DxValueStringOnly;

                                int counter = 0;

                                foreach (var item in AddedValues)
                                {
                                    counter++;
                                }

                                if (counter < 16)
                                {

                                    Registries.DxValue = AddedValues;
                                    Registries.DxValueStringOnly = AddedValues;

                                    PleaseWait.Wait();

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

                            if (Registries.CxToAddAndSub == 0 && Registries.DxToAddAndSub == 0 && Registries.CxValueStringOnly == 0.ToString() && Registries.DxValueStringOnly == 0.ToString())
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

                                    PleaseWait.Wait();

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
                                Console.WriteLine("\nYou can't add string-to-number, number-to-string or string stored as bit of informations (SABOI) to casual string or number. Please add number-to-number, string-to-string or (SABI)string-to-(SABI)string. Press any key to try again");
                                Console.ResetColor();
                                Console.ReadLine();
                                break;
                            }
                        }


                    }

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

                                    PleaseWait.Wait();

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

                            if (Registries.DxToAddAndSub == 0 && Registries.AxToAddAndSub == 0 && Registries.DxValueStringOnly != 0.ToString() && Registries.AxValueStringOnly != 0.ToString())
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                Console.WriteLine("You have choosen AX Registry, adding process is about to begin");
                                Console.ResetColor();

                                string AddedValues = Registries.DxValueStringOnly + Registries.AxValueStringOnly;

                                int counter = 0;

                                foreach (var item in AddedValues)
                                {
                                    counter++;
                                }

                                if (counter < 16)
                                {

                                    Registries.AxValue = AddedValues;
                                    Registries.AxValueStringOnly = AddedValues;

                                    PleaseWait.Wait();

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

                            if (Registries.DxToAddAndSub == 0 && Registries.AxToAddAndSub == 0 && Registries.DxValueStringOnly == 0.ToString() && Registries.AxValueStringOnly == 0.ToString())
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

                                    PleaseWait.Wait();

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
                                Console.WriteLine("\nYou can't add string-to-number, number-to-string or string stored as bit of informations (SABOI) to casual string or number. Please add number-to-number, string-to-string or (SABI)string-to-(SABI)string. Press any key to try again");
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

                                    PleaseWait.Wait();

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


                            if (Registries.DxToAddAndSub == 0 && Registries.BxToAddAndSub == 0 && Registries.DxValueStringOnly != 0.ToString() && Registries.BxValueStringOnly != 0.ToString())
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                Console.WriteLine("You have choosen BX Registry, adding process is about to begin");
                                Console.ResetColor();

                                string AddedValues = Registries.DxValueStringOnly + Registries.BxValueStringOnly;

                                int counter = 0;

                                foreach (var item in AddedValues)
                                {
                                    counter++;
                                }

                                if (counter < 16)
                                {

                                    Registries.BxValue = AddedValues;
                                    Registries.BxValueStringOnly = AddedValues;

                                    PleaseWait.Wait();

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

                            if (Registries.DxToAddAndSub == 0 && Registries.BxToAddAndSub == 0 && Registries.DxValueStringOnly == 0.ToString() && Registries.BxValueStringOnly == 0.ToString())
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

                                    PleaseWait.Wait();

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
                                Console.WriteLine("\nYou can't add string-to-number, number-to-string or string stored as bit of informations (SABOI) to casual string or number. Please add number-to-number, string-to-string or (SABI)string-to-(SABI)string. Press any key to try again");
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

                                    PleaseWait.Wait();

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

                            if (Registries.DxToAddAndSub == 0 && Registries.CxToAddAndSub == 0 && Registries.DxValueStringOnly != 0.ToString() && Registries.CxValueStringOnly != 0.ToString())
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                Console.WriteLine("You have choosen CX Registry, adding process is about to begin");
                                Console.ResetColor();

                                string AddedValues = Registries.DxValueStringOnly + Registries.CxValueStringOnly;

                                int counter = 0;

                                foreach (var item in AddedValues)
                                {
                                    counter++;
                                }

                                if (counter < 16)
                                {

                                    Registries.CxValue = AddedValues;
                                    Registries.CxValueStringOnly = AddedValues;

                                    PleaseWait.Wait();

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

                            if (Registries.DxToAddAndSub == 0 && Registries.CxToAddAndSub == 0 && Registries.DxValueStringOnly == 0.ToString() && Registries.CxValueStringOnly == 0.ToString())
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

                                    PleaseWait.Wait();

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
                                Console.WriteLine("\nYou can't add string-to-number, number-to-string or string stored as bit of informations (SABOI) to casual string or number. Please add number-to-number, string-to-string or (SABI)string-to-(SABI)string. Press any key to try again");
                                Console.ResetColor();
                                Console.ReadLine();
                                break;
                            }
                        }
                    }
                    else
                    {
                        ADD();
                    }
                }

                //=-=-=-=-=-=-=-=--=-=--=-=-=-=-=-=-=-=-=-=-=-=-=-=-==-=-=-=-=-=-=-=--=-=--=-=-=-=-=-=-=-=-=-=-=-=-=-=-==-=-=-=-=-=-=-=--=-=--=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
                //=-=-=-=-=-=-=-=--=-=--=-=-=-=-=-=-=-=-=-=-=-=-=-=-==-=-=-=-=-=-=-=--=-=--=-=-=-=-=-=-=-=-=-=-=-=-=-=-==-=-=-=-=-=-=-=--=-=--=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
                //=-=-=-=-=-=-=-=--=-=--=-=-=-=-=-=-=-=-=-=-=-=-=-=-==-=-=-=-=-=-=-=--=-=--=-=-=-=-=-=-=-=-=-=-=-=-=-=-==-=-=-=-=-=-=-=--=-=--=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
                //=-=-=-=-=-=-=-=--=-=--=-=-=-=-=-=-=-=-=-=-=-=-=-=-==-=-=-=-=-=-=-=--=-=--=-=-=-=-=-=-=-=-=-=-=-=-=-=-==-=-=-=-=-=-=-=--=-=--=-=-=-=-=-=-=-=-=-=-=-=-=-=-=

                if (TriggerAction == 2)
                {

                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("Select registry you wanna add value to: \n");
                    Console.ResetColor();
                    Console.WriteLine("(1) AX\n");
                    Console.WriteLine("(2) BX\n");
                    Console.WriteLine("(3) CX\n");
                    Console.WriteLine("(4) DX\n");

                    while (true)
                    {
                        int ChoosenRegistry;
                        int.TryParse(Console.ReadLine(), out ChoosenRegistry);

                        if (ChoosenRegistry == 1)
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            Console.WriteLine("You have choosen AX registry. Please enter number or word you wanna add to AX: \n");
                            Console.ResetColor();

                            string Value = Console.ReadLine();
                            bool isNumber = int.TryParse(Value, out int EnteredValue);

                            if (isNumber)
                            {
                                bool isAxRegistryNumber = true;

                                if (Registries.AxValue == 0.ToString())
                                    isAxRegistryNumber = int.TryParse(Registries.AxValue, out int variable);

                                if (Registries.AxValue != 0.ToString() && Registries.AxToAddAndSub == 0)
                                {
                                    isAxRegistryNumber = false;
                                }
                                if (isAxRegistryNumber)
                                {
                                    Console.Clear();
                                    if (Enumerable.Range(-32767, 65535).Contains((Registries.AxToAddAndSub + EnteredValue)))
                                    {
                                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                        Console.WriteLine("Adding process is about to begin");
                                        Console.ResetColor();

                                        Registries.AxValue = DecToHex.DecimalToHexadecimal((Registries.AxToAddAndSub + EnteredValue));
                                        Registries.AxToAddAndSub += EnteredValue;

                                        PleaseWait.Wait();

                                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                                        Console.WriteLine("\nSuccess! Entered value has been successfully added to AX registry. Press any key to return.");
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
                                    Console.WriteLine("\nYou can't exceed 16 bits and add null, string-to-number, number-to-string or string stored as bit of informations (SABOI) to casual string or number. Please add number-to-number, string-to-string or (SABI)string-to-(SABI)string. Press any key to try again");
                                    Console.ResetColor();
                                    Console.ReadLine();
                                    break;
                                }
                            }

                            if (!isNumber)
                            {

                                bool isAxRegistryNumber = false;

                                if (Registries.AxToAddAndSub != 0)
                                {
                                    isAxRegistryNumber = true;
                                }
                                if (Registries.AxValue == 0.ToString())
                                {
                                    isAxRegistryNumber = true;
                                }

                                if (!isAxRegistryNumber && Registries.AxValue != 0.ToString() && Registries.AxValueStringOnly==0.ToString())
                                {

                                    string AddedValues = Registries.AxValue + TextToHex.AsciiToHex(Value);

                                    bool isResultSixteenBits = ushort.TryParse(AddedValues, out ushort SixteenBitsResult);

                                    if (isResultSixteenBits)
                                    {
                                        Console.Clear();
                                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                        Console.WriteLine("Adding process is about to begin");
                                        Console.ResetColor();

                                        Registries.AxValue = AddedValues;

                                        PleaseWait.Wait();

                                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                                        Console.WriteLine("\nSuccess! Entered value has been successfully added to AX registry. Press any key to return.");
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

                                if (!isAxRegistryNumber && Registries.AxValue != 0.ToString() && Registries.AxValueStringOnly!=0.ToString())
                                {

                                    string AddedValues = Registries.AxValue + Value;

                                    int counter = 0;

                                    foreach (var item in AddedValues)
                                    {
                                        counter++;
                                    }

                                    if (counter<16)
                                    {
                                        Console.Clear();
                                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                        Console.WriteLine("Adding process is about to begin");
                                        Console.ResetColor();

                                        Registries.AxValue = AddedValues;
                                        Registries.AxValueStringOnly = AddedValues;

                                        PleaseWait.Wait();

                                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                                        Console.WriteLine("\nSuccess! Entered value has been successfully added to AX registry. Press any key to return.");
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
                                    Console.WriteLine("\nYou can't exceed 16 bits and add null, string-to-number, number-to-string or string stored as bit of informations (SABOI) to casual string or number. Please add number-to-number, string-to-string or (SABI)string-to-(SABI)string. Press any key to try again");
                                    Console.ResetColor();
                                    Console.ReadLine();
                                    break;
                                }
                            }
                        }

                        if (ChoosenRegistry == 2)
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            Console.WriteLine("You have choosen BX registry. Please enter number or word you wanna add to BX: \n");
                            Console.ResetColor();

                            string Value = Console.ReadLine();
                            bool isNumber = int.TryParse(Value, out int EnteredValue);

                            if (isNumber)
                            {
                                bool isAxRegistryNumber = true;

                                if (Registries.BxValue == 0.ToString())
                                    isAxRegistryNumber = int.TryParse(Registries.BxValue, out int variable);

                                if (Registries.BxValue != 0.ToString() && Registries.BxToAddAndSub == 0)
                                {
                                    isAxRegistryNumber = false;
                                }
                                if (isAxRegistryNumber)
                                {
                                    Console.Clear();
                                    if (Enumerable.Range(-32767, 65535).Contains((Registries.BxToAddAndSub + EnteredValue)))
                                    {
                                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                        Console.WriteLine("Adding process is about to begin");
                                        Console.ResetColor();

                                        Registries.BxValue = DecToHex.DecimalToHexadecimal((Registries.BxToAddAndSub + EnteredValue));
                                        Registries.BxToAddAndSub += EnteredValue;

                                        PleaseWait.Wait();

                                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                                        Console.WriteLine("\nSuccess! Entered value has been successfully added to BX registry. Press any key to return.");
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
                                    Console.WriteLine("\nYou can't exceed 16 bits and add null, string-to-number, number-to-string or string stored as bit of informations (SABOI) to casual string or number. Please add number-to-number, string-to-string or (SABI)string-to-(SABI)string. Press any key to try again");
                                    Console.ResetColor();
                                    Console.ReadLine();
                                    break;
                                }
                            }

                            if (!isNumber)
                            {

                                bool isAxRegistryNumber = false;

                                if (Registries.BxToAddAndSub != 0)
                                {
                                    isAxRegistryNumber = true;
                                }
                                if (Registries.BxValue == 0.ToString())
                                {
                                    isAxRegistryNumber = true;
                                }

                                if (!isAxRegistryNumber && Registries.BxValue != 0.ToString() && Registries.BxValueStringOnly==0.ToString())
                                {

                                    string AddedValues = Registries.BxValue + TextToHex.AsciiToHex(Value);

                                    bool isResultSixteenBits = ushort.TryParse(AddedValues, out ushort SixteenBitsResult);

                                    if (isResultSixteenBits)
                                    {
                                        Console.Clear();
                                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                        Console.WriteLine("Adding process is about to begin");
                                        Console.ResetColor();

                                        Registries.BxValue = AddedValues;

                                        PleaseWait.Wait();

                                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                                        Console.WriteLine("\nSuccess! Entered value has been successfully added to BX registry. Press any key to return.");
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

                                if (!isAxRegistryNumber && Registries.BxValue != 0.ToString() && Registries.BxValueStringOnly != 0.ToString())
                                {

                                    string AddedValues = Registries.BxValue + Value;

                                    int counter = 0;

                                    foreach (var item in AddedValues)
                                    {
                                        counter++;
                                    }

                                    if (counter < 16)
                                    {
                                        Console.Clear();
                                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                        Console.WriteLine("Adding process is about to begin");
                                        Console.ResetColor();

                                        Registries.BxValue = AddedValues;
                                        Registries.BxValueStringOnly = AddedValues;

                                        PleaseWait.Wait();

                                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                                        Console.WriteLine("\nSuccess! Entered value has been successfully added to BX registry. Press any key to return.");
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
                                    Console.WriteLine("\nYou can't exceed 16 bits and add null, string-to-number, number-to-string or string stored as bit of informations (SABOI) to casual string or number. Please add number-to-number, string-to-string or (SABI)string-to-(SABI)string. Press any key to try again");
                                    Console.ResetColor();
                                    Console.ReadLine();
                                    break;
                                }
                            }
                        }

                        if (ChoosenRegistry == 3)
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            Console.WriteLine("You have choosen CX registry. Please enter number or word you wanna add to CX: \n");
                            Console.ResetColor();

                            string Value = Console.ReadLine();
                            bool isNumber = int.TryParse(Value, out int EnteredValue);

                            if (isNumber)
                            {
                                bool isAxRegistryNumber = true;

                                if (Registries.CxValue == 0.ToString())
                                    isAxRegistryNumber = int.TryParse(Registries.CxValue, out int variable);

                                if (Registries.CxValue != 0.ToString() && Registries.CxToAddAndSub == 0)
                                {
                                    isAxRegistryNumber = false;
                                }
                                if (isAxRegistryNumber)
                                {
                                    Console.Clear();
                                    if (Enumerable.Range(-32767, 65535).Contains((Registries.CxToAddAndSub + EnteredValue)))
                                    {
                                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                        Console.WriteLine("Adding process is about to begin");
                                        Console.ResetColor();

                                        Registries.CxValue = DecToHex.DecimalToHexadecimal((Registries.CxToAddAndSub + EnteredValue));
                                        Registries.CxToAddAndSub += EnteredValue;

                                        PleaseWait.Wait();

                                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                                        Console.WriteLine("\nSuccess! Entered value has been successfully added to CX registry. Press any key to return.");
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
                                    Console.WriteLine("\nYou can't exceed 16 bits and add null, string-to-number, number-to-string or string stored as bit of informations (SABOI) to casual string or number. Please add number-to-number, string-to-string or (SABI)string-to-(SABI)string. Press any key to try again");
                                    Console.ResetColor();
                                    Console.ReadLine();
                                    break;
                                }
                            }

                            if (!isNumber)
                            {

                                bool isAxRegistryNumber = false;

                                if (Registries.CxToAddAndSub != 0)
                                {
                                    isAxRegistryNumber = true;
                                }
                                if (Registries.CxValue == 0.ToString())
                                {
                                    isAxRegistryNumber = true;
                                }

                                if (!isAxRegistryNumber && Registries.CxValue != 0.ToString() && Registries.CxValueStringOnly==0.ToString())
                                {

                                    string AddedValues = Registries.CxValue + TextToHex.AsciiToHex(Value);

                                    bool isResultSixteenBits = ushort.TryParse(AddedValues, out ushort SixteenBitsResult);

                                    if (isResultSixteenBits)
                                    {
                                        Console.Clear();
                                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                        Console.WriteLine("Adding process is about to begin");
                                        Console.ResetColor();

                                        Registries.CxValue = AddedValues;

                                        PleaseWait.Wait();

                                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                                        Console.WriteLine("\nSuccess! Entered value has been successfully added to CX registry. Press any key to return.");
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

                                if (!isAxRegistryNumber && Registries.CxValue != 0.ToString() && Registries.CxValueStringOnly != 0.ToString())
                                {

                                    string AddedValues = Registries.CxValue + Value;

                                    int counter = 0;

                                    foreach (var item in AddedValues)
                                    {
                                        counter++;
                                    }

                                    if (counter < 16)
                                    {
                                        Console.Clear();
                                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                        Console.WriteLine("Adding process is about to begin");
                                        Console.ResetColor();

                                        Registries.CxValue = AddedValues;
                                        Registries.CxValueStringOnly = AddedValues;

                                        PleaseWait.Wait();

                                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                                        Console.WriteLine("\nSuccess! Entered value has been successfully added to CX registry. Press any key to return.");
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
                                    Console.WriteLine("\nYou can't exceed 16 bits and add null, string-to-number, number-to-string or string stored as bit of informations (SABOI) to casual string or number. Please add number-to-number, string-to-string or (SABI)string-to-(SABI)string. Press any key to try again");
                                    Console.ResetColor();
                                    Console.ReadLine();
                                    break;
                                }
                            }
                        }

                        if (ChoosenRegistry == 4)
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            Console.WriteLine("You have choosen DX registry. Please enter number or word you wanna add to DX: \n");
                            Console.ResetColor();

                            string Value = Console.ReadLine();
                            bool isNumber = int.TryParse(Value, out int EnteredValue);

                            if (isNumber)
                            {
                                bool isAxRegistryNumber = true;

                                if (Registries.DxValue == 0.ToString())
                                    isAxRegistryNumber = int.TryParse(Registries.DxValue, out int variable);

                                if (Registries.DxValue != 0.ToString() && Registries.DxToAddAndSub == 0)
                                {
                                    isAxRegistryNumber = false;
                                }
                                if (isAxRegistryNumber)
                                {
                                    Console.Clear();
                                    if (Enumerable.Range(-32767, 65535).Contains((Registries.DxToAddAndSub + EnteredValue)))
                                    {
                                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                        Console.WriteLine("Adding process is about to begin");
                                        Console.ResetColor();

                                        Registries.DxValue = DecToHex.DecimalToHexadecimal((Registries.DxToAddAndSub + EnteredValue));
                                        Registries.DxToAddAndSub += EnteredValue;

                                        PleaseWait.Wait();

                                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                                        Console.WriteLine("\nSuccess! Entered value has been successfully added to DX registry. Press any key to return.");
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
                                    Console.WriteLine("\nYou can't exceed 16 bits and add null, string-to-number, number-to-string or string stored as bit of informations (SABOI) to casual string or number. Please add number-to-number, string-to-string or (SABI)string-to-(SABI)string. Press any key to try again");
                                    Console.ResetColor();
                                    Console.ReadLine();
                                    break;
                                }
                            }

                            if (!isNumber)
                            {

                                bool isAxRegistryNumber = false;

                                if (Registries.DxToAddAndSub != 0)
                                {
                                    isAxRegistryNumber = true;
                                }
                                if (Registries.DxValue == 0.ToString())
                                {
                                    isAxRegistryNumber = true;
                                }

                                if (!isAxRegistryNumber && Registries.DxValue != 0.ToString() && Registries.DxValueStringOnly==0.ToString())
                                {

                                    string AddedValues = Registries.DxValue + TextToHex.AsciiToHex(Value);

                                    bool isResultSixteenBits = ushort.TryParse(AddedValues, out ushort SixteenBitsResult);

                                    if (isResultSixteenBits)
                                    {
                                        Console.Clear();
                                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                        Console.WriteLine("Adding process is about to begin");
                                        Console.ResetColor();

                                        Registries.DxValue = AddedValues;

                                        PleaseWait.Wait();

                                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                                        Console.WriteLine("\nSuccess! Entered value has been successfully added to DX registry. Press any key to return.");
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

                                if (!isAxRegistryNumber && Registries.DxValue != 0.ToString() && Registries.DxValueStringOnly != 0.ToString())
                                {

                                    string AddedValues = Registries.DxValue + Value;

                                    int counter = 0;

                                    foreach (var item in AddedValues)
                                    {
                                        counter++;
                                    }

                                    if (counter < 16)
                                    {
                                        Console.Clear();
                                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                        Console.WriteLine("Adding process is about to begin");
                                        Console.ResetColor();

                                        Registries.DxValue = AddedValues;
                                        Registries.DxValueStringOnly = AddedValues;

                                        PleaseWait.Wait();

                                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                                        Console.WriteLine("\nSuccess! Entered value has been successfully added to DX registry. Press any key to return.");
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
                                    Console.WriteLine("\nYou can't exceed 16 bits and add null, string-to-number, number-to-string or string stored as bit of informations (SABOI) to casual string or number. Please add number-to-number, string-to-string or (SABI)string-to-(SABI)string. Press any key to try again");
                                    Console.ResetColor();
                                    Console.ReadLine();
                                    break;
                                }
                            }
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                else
                {
                    break;
                }
            }
        }
    }

}

