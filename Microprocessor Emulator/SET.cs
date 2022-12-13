using Microprocessor_Emualtor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Microprocessor_Emulator
{
    public static class SET
    {
        public static void SETValues()
        {
            while (true)
            {

                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("\nSelect registry you want to set value in\n");
                Console.ResetColor();
                Console.WriteLine("(1) AX Registry\n");
                Console.WriteLine("(2) BX Registry\n");
                Console.WriteLine("(3) CX Registry\n");
                Console.WriteLine("(4) DX Registry\n");
                Console.WriteLine("\n() Any other key to return menu\n");

                try
                {
                    int ChoosenRegistry = int.Parse(Console.ReadLine());

                    switch (ChoosenRegistry)
                    {

                        case 1:
                            ChoosenRegistryMethod(ref Registries.AxValue, ref Registries.AxToAddAndSub, ref Registries.AxValueStringOnly, "AX");
                            break;

                        case 2:
                            ChoosenRegistryMethod(ref Registries.BxValue, ref Registries.BxToAddAndSub, ref Registries.BxValueStringOnly, "BX");
                            break;

                        case 3:
                            ChoosenRegistryMethod(ref Registries.CxValue, ref Registries.CxToAddAndSub, ref Registries.CxValueStringOnly, "CX");
                            break;

                        case 4:
                            ChoosenRegistryMethod(ref Registries.DxValue, ref Registries.DxToAddAndSub, ref Registries.DxValueStringOnly, "DX");
                            break;

                        default:
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Please choose correctly! Press any key to try again");
                            Console.ResetColor();
                            Console.ReadLine();
                            Console.Clear();
                            continue;
                    }
                }

                catch
                {
                    break;
                }

                break;
            }
        }

        //Method that displays SET options for each registry, where Registry is displayed value on dashboard

        public static void ChoosenRegistryMethod(ref string Registry, ref int RegistryAuxiliaryIntValue, ref string RegistryAuxiliaryStringValue, string RegistryToDisplayMessages)
        {
            while (true)
            {

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine($"\nYou have choosen {RegistryToDisplayMessages} Registry, what you wanna enter? \n");
                Console.ResetColor();
                Console.WriteLine("(1) number\n");
                Console.WriteLine("(2) string\n");
                Console.WriteLine("(3) string stored as bits of information\n");
                Console.WriteLine("\n() Any other key to return menu\n");

                int ChoosenOperation = int.Parse(Console.ReadLine());

                switch (ChoosenOperation)
                {
                    case 1:
                        FirstChoosenOperation(ref Registry, ref RegistryAuxiliaryIntValue, ref RegistryAuxiliaryStringValue);
                        break;

                    case 2:
                        SecondChoosenOperation(ref Registry, ref RegistryAuxiliaryIntValue, ref RegistryAuxiliaryStringValue);
                        break;

                    case 3:
                        ThirdChoosenOperation(ref Registry, ref RegistryAuxiliaryIntValue, ref RegistryAuxiliaryStringValue);
                        break;
                }
            }
        }

        // Method responsible for setting number in choosen registry

        public static void FirstChoosenOperation(ref string Registry, ref int RegistryAuxiliaryIntValue, ref string RegistryAuxiliaryStringValue)
        {
            while (true)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("\nPlease enter number: \n");
                Console.ResetColor();

                bool isNumber = int.TryParse(Console.ReadLine(), out int AxResult);

                if (isNumber)
                {
                    /*If entered value is in 16-bits range, the value is assigning to register, so it's Auxiliary Int Value. Auxiliary String Value is reseted
                      to make sooner entered value recognition easier*/

                    if (Enumerable.Range(-32767, 65535).Contains(AxResult))
                    {
                        var AxToHex = DecToHex.DecimalToHexadecimal(AxResult);

                        Registry = AxToHex;
                        RegistryAuxiliaryIntValue = AxResult;
                        RegistryAuxiliaryStringValue = 0.ToString();

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
                        Console.WriteLine("16-bits exceeded, please enter correct value. Press Any key to try again!");
                        Console.ResetColor();
                        Console.ReadLine();
                        continue;

                    }
                }

                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("\nIncorrect number please try again!");
                    Console.ResetColor();
                    Console.ReadLine();
                    continue;
                }
            }
        }

        // Method responsible for setting string in choosen registry

        public static void SecondChoosenOperation(ref string Registry, ref int RegistryAuxiliaryIntValue, ref string RegistryAuxiliaryStringValue)
        {
            while (true)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("\nPlease enter string: \n");
                Console.ResetColor();

                string AxResultstr = Console.ReadLine();
                bool isNumber = int.TryParse(AxResultstr, out int AxResult);

                if (!isNumber)
                {
                    int count = 0;

                    //checks length of given string
                    foreach (var znak in AxResultstr)
                    {
                        count++;
                    }

                    if (count < 16)
                    {
                        Registry = AxResultstr;
                        RegistryAuxiliaryIntValue = 0;
                        RegistryAuxiliaryStringValue = AxResultstr;

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
                        Console.WriteLine("\n16 bits exceeded. Any key to try again");
                        Console.ResetColor();
                        Console.ReadLine();
                        continue;
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("\nPlease enter string!\n");
                    Console.ResetColor();
                    Console.ReadLine();
                    continue;
                }
            }
        }

        // Method responsible for setting string as bits of information in choosen registry

        public static void ThirdChoosenOperation(ref string Registry, ref int RegistryAuxiliaryIntValue, ref string RegistryAuxiliaryStringValue)
        {
            while (true)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("\nPlease enter string: \n");
                Console.ResetColor();

                string AxResultstr = Console.ReadLine();
                bool isNumber = int.TryParse(AxResultstr, out int AxResult);

                if (!isNumber)
                {
                    //converts given number to HEX value to check
                    //if converted value exceeds 16-bits
                    var result = TextToHex.AsciiToHex(AxResultstr);

                    bool isResultSixteenBits = ushort.TryParse(result, out ushort SixteenBitsResult);

                    if (isResultSixteenBits)
                    {
                        Registry = result;
                        RegistryAuxiliaryIntValue = 0;
                        RegistryAuxiliaryStringValue = 0.ToString();

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
                        Console.WriteLine("\n16 bits exceeded. Any key to try again");
                        Console.ResetColor();
                        Console.ReadLine();
                        continue;
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("\nPlease enter string!\n");
                    Console.ResetColor();
                    Console.ReadLine();
                    continue;
                }
            }
        }
    }
}

