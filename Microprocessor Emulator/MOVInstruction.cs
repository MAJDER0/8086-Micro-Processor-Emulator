using Microprocessor_Emualtor;
using Microsoft.Win32;
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

                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("Select one: \n");
                Console.ResetColor();

                Console.WriteLine("(1) Move registry value to choosen registry\n");
                Console.WriteLine("(2) Move number to choosen registry\n");
                Console.WriteLine("\n() Press any other key to return menu\n");

                int.TryParse(Console.ReadLine(), out int TriggerAction);
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
                        int.TryParse(Console.ReadLine(), out int ChoosenRegistry);
                        Console.WriteLine();
                        Console.Clear();

                        switch (ChoosenRegistry)
                        {
                            case 1:
                                SelectedRegistry(ref Registries.AxValue, ref Registries.AxToAddAndSub, ref Registries.AxValueStringOnly, "AX",
                                 ref Registries.BxValue, ref Registries.BxToAddAndSub, ref Registries.BxValueStringOnly, "BX",
                                     ref Registries.CxValue, ref Registries.CxToAddAndSub, ref Registries.CxValueStringOnly, "CX",
                                         ref Registries.DxValue, ref Registries.DxToAddAndSub, ref Registries.DxValueStringOnly, "DX");
                                break;

                            case 2:
                                SelectedRegistry(ref Registries.BxValue, ref Registries.BxToAddAndSub, ref Registries.BxValueStringOnly, "BX",
                                 ref Registries.AxValue, ref Registries.AxToAddAndSub, ref Registries.AxValueStringOnly, "AX",
                                     ref Registries.CxValue, ref Registries.CxToAddAndSub, ref Registries.CxValueStringOnly, "CX",
                                        ref Registries.DxValue, ref Registries.DxToAddAndSub, ref Registries.DxValueStringOnly, "DX");
                                break;

                            case 3:
                                SelectedRegistry(ref Registries.CxValue, ref Registries.CxToAddAndSub, ref Registries.CxValueStringOnly, "CX",
                                 ref Registries.AxValue, ref Registries.AxToAddAndSub, ref Registries.AxValueStringOnly, "AX",
                                     ref Registries.BxValue, ref Registries.BxToAddAndSub, ref Registries.BxValueStringOnly, "BX",
                                         ref Registries.DxValue, ref Registries.DxToAddAndSub, ref Registries.DxValueStringOnly, "DX");
                                break;

                            case 4:
                                SelectedRegistry(ref Registries.DxValue, ref Registries.DxToAddAndSub, ref Registries.DxValueStringOnly, "DX",
                                 ref Registries.AxValue, ref Registries.AxToAddAndSub, ref Registries.AxValueStringOnly, "AX",
                                     ref Registries.BxValue, ref Registries.BxToAddAndSub, ref Registries.BxValueStringOnly, "BX",
                                         ref Registries.CxValue, ref Registries.CxToAddAndSub, ref Registries.CxValueStringOnly, "CX");
                                break;

                            case 0:
                                break;

                            default:
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("Choose correctly");
                                Console.ResetColor();
                                continue;
                        }
                        break;
                    }
                }

                if (TriggerAction == 2)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("Select registry you wanna Move value in: \n");
                    Console.ResetColor();
                    Console.WriteLine("(1) AX\n");
                    Console.WriteLine("(2) BX\n");
                    Console.WriteLine("(3) CX\n");
                    Console.WriteLine("(4) DX\n");

                    while (true)
                    {
                        int.TryParse(Console.ReadLine(), out int ChoosenRegistry);

                        switch (ChoosenRegistry)
                        {

                            case 1:
                                SecondChoosenOperation(ref Registries.AxValue, ref Registries.AxToAddAndSub, ref Registries.AxValueStringOnly, "AX");
                                break;

                            case 2:
                                SecondChoosenOperation(ref Registries.BxValue, ref Registries.BxToAddAndSub, ref Registries.BxValueStringOnly, "BX");
                                break;

                            case 3:
                                SecondChoosenOperation(ref Registries.CxValue, ref Registries.CxToAddAndSub, ref Registries.CxValueStringOnly, "CX");
                                break;

                            case 4:
                                SecondChoosenOperation(ref Registries.DxValue, ref Registries.DxToAddAndSub, ref Registries.DxValueStringOnly, "DX");
                                break;

                            default:
                                break;
                        }
                        break;
                    }
                }
                break;
            }
        }

        //Method that triggers further actions for choosen registry. SelectedRegistry is registry you've choosen. Second, Third and Fourth are the next ones
        //in alphabetical order. For Example if Choosen Registry is Bx, Bx registry is "Selected Registry" And then SecondRegistry is AX, ThirdRegistry is CX
        //and so on. Constructors of the following methods are based on those constructors bellow.

        public static void SelectedRegistry(ref string SelectedRegistry, ref int FirstRegistryAuxiliaryInt, ref string FirstRegistryAuxiliaryString, string FirstRegistryNameToMessages,
            ref string SecondRegistry, ref int SecondRegistryAuxiliaryInt, ref string SecondRegistryAuxiliaryString, string SecondRegistryNameToMessages,
            ref string ThirdRegistry, ref int ThirdRegistryAuxiliaryInt, ref string ThirdRegistryAuxiliaryString, string ThirdRegistryNameToMessages,
            ref string FourthRegistry, ref int FourthRegistryAuxiliaryInt, ref string FourthRegistryAuxiliaryString, string FourthRegistryNameToMessages)
        {

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine($"You have choosen {FirstRegistryNameToMessages} Registry.");
                Console.ResetColor();


                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("Choose registry you want to move that value in: \n");
                Console.ResetColor();
                Console.WriteLine($"(1) {SecondRegistryNameToMessages}\n");
                Console.WriteLine($"(2) {ThirdRegistryNameToMessages}\n");
                Console.WriteLine($"(3) {FourthRegistryNameToMessages}\n");

                while (true)
                {
                    bool isNumber = int.TryParse(Console.ReadLine(), out int SelectedRegistryToMove);
                    Console.WriteLine();

                    if (isNumber)
                    {
                        try
                        {
                            if (SelectedRegistryToMove == 1)

                            {
                                ChoosenRegistryToMove(ref SelectedRegistry, ref FirstRegistryAuxiliaryInt, ref FirstRegistryAuxiliaryString,
                                    ref SecondRegistry, ref SecondRegistryAuxiliaryInt, ref SecondRegistryAuxiliaryString, SecondRegistryNameToMessages);
                            }

                            if (SelectedRegistryToMove == 2)
                            {
                                ChoosenRegistryToMove(ref SelectedRegistry, ref FirstRegistryAuxiliaryInt, ref FirstRegistryAuxiliaryString,
                                    ref ThirdRegistry, ref ThirdRegistryAuxiliaryInt, ref ThirdRegistryAuxiliaryString, ThirdRegistryNameToMessages);

                            }

                            if (SelectedRegistryToMove == 3)
                            {
                                ChoosenRegistryToMove(ref SelectedRegistry, ref FirstRegistryAuxiliaryInt, ref FirstRegistryAuxiliaryString,
                                    ref FourthRegistry, ref FourthRegistryAuxiliaryInt, ref FourthRegistryAuxiliaryString, FourthRegistryNameToMessages);
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

        //Method that moves one Registry value to another registry. FirstRegistryValueToBeingMoved is value which location is about to change
        //to SecondRegistryValueAndFinalLocation. Basically those Constructors are given from the method above.

        public static void ChoosenRegistryToMove(ref string FirstRegistryValueToBeingMoved, ref int FirstRegistryAuxiliaryInt, ref string FirstRegistryAuxiliaryString,
            ref string SecondRegistryValueAndFinalLocation, ref int SecondRegistryAuxiliaryInt, ref string SecondRegistryAuxiliaryString, string SecondRegistryNameToMessages)
        {

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine($"You have choosen {SecondRegistryNameToMessages} registry, moving process is about to begin: \n");
            Console.ResetColor();

            //Assigning value to finall location and reseting all values from first location
            //which helps in further checks.
            SecondRegistryValueAndFinalLocation = FirstRegistryValueToBeingMoved;
            SecondRegistryAuxiliaryInt = FirstRegistryAuxiliaryInt;
            SecondRegistryAuxiliaryString = FirstRegistryAuxiliaryString;
            FirstRegistryValueToBeingMoved = 0.ToString();
            FirstRegistryAuxiliaryInt = 0;
            FirstRegistryAuxiliaryString = 0.ToString();

            PleaseWait.Wait();

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\nSuccess! Press any key to return");
            Console.ResetColor();
            Console.ReadLine();
            Program.Main();
        }

        //Method that moves given number into choosen registry 

        public static void SecondChoosenOperation(ref string RegistryToDisplayOnDashBoard, ref int ItsAuxiliaryIntValue, ref string ItsAuxiliaryStringValue, string RegistryStringToDisplayMessages)
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
                    if (Enumerable.Range(-32767, 65535).Contains(AxResult))
                    {
                        var AxToHex = DecToHex.DecimalToHexadecimal(AxResult);

                        RegistryToDisplayOnDashBoard = AxToHex;
                        ItsAuxiliaryIntValue = AxResult;
                        ItsAuxiliaryStringValue = 0.ToString();

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
    }
}
