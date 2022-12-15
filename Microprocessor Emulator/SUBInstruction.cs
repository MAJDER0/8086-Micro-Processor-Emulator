using Microprocessor_Emualtor;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microprocessor_Emulator
{
    public class SUBInstruction
    {
        public static void SUB()
        {
            while (true)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("What would you like to substract?\n");
                Console.ResetColor();

                Console.WriteLine("(1) Substract one registry value from another\n");
                Console.WriteLine("(2) Substract number from choosen registry\n");
                Console.WriteLine("\n() Any other key to return\n");

                int.TryParse(Console.ReadLine(), out int TriggerAction);

                if (TriggerAction == 1)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("Select registry you wanna substract from another: \n");
                    Console.ResetColor();
                    Console.WriteLine("(1) AX\n");
                    Console.WriteLine("(2) BX\n");
                    Console.WriteLine("(3) CX\n");
                    Console.WriteLine("(4) DX\n");

                    int.TryParse(Console.ReadLine(), out int ChoosenRegistry);

                    switch (ChoosenRegistry)
                    {
                        case 1:
                            ChoosenRegistryToSubstractMethod(ref Registries.AxValue, ref Registries.AxToAddAndSub, "AX",
                               ref Registries.BxValue, ref Registries.BxToAddAndSub, "BX",
                                ref Registries.CxValue, ref Registries.CxToAddAndSub, "CX",
                                    ref Registries.DxValue, ref Registries.DxToAddAndSub, "DX");
                            break;

                        case 2:
                            ChoosenRegistryToSubstractMethod(ref Registries.BxValue, ref Registries.BxToAddAndSub, "BX",
                               ref Registries.AxValue, ref Registries.AxToAddAndSub, "AX",
                                ref Registries.CxValue, ref Registries.CxToAddAndSub, "CX",
                                    ref Registries.DxValue, ref Registries.DxToAddAndSub, "DX");
                            break;

                        case 3:
                            ChoosenRegistryToSubstractMethod(ref Registries.CxValue, ref Registries.CxToAddAndSub, "CX",
                               ref Registries.AxValue, ref Registries.AxToAddAndSub, "AX",
                                ref Registries.BxValue, ref Registries.BxToAddAndSub, "BX",
                                    ref Registries.DxValue, ref Registries.DxToAddAndSub, "DX");
                            break;

                        case 4:
                            ChoosenRegistryToSubstractMethod(ref Registries.DxValue, ref Registries.DxToAddAndSub, "DX",
                               ref Registries.AxValue, ref Registries.AxToAddAndSub, "AX",
                                ref Registries.BxValue, ref Registries.BxToAddAndSub, "BX",
                                    ref Registries.CxValue, ref Registries.CxToAddAndSub, "CX");
                            break;

                        default:
                            break;
                    }
                }

                if (TriggerAction == 2)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("Select registry you want to substract number from: \n");
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
                                ChoosenRegistryToSubNumber(ref Registries.AxValue, ref Registries.AxToAddAndSub, "AX");
                                break;

                            case 2:
                                ChoosenRegistryToSubNumber(ref Registries.BxValue, ref Registries.BxToAddAndSub, "BX");
                                break;

                            case 3:
                                ChoosenRegistryToSubNumber(ref Registries.CxValue, ref Registries.CxToAddAndSub, "CX");
                                break;

                            case 4:
                                ChoosenRegistryToSubNumber(ref Registries.DxValue, ref Registries.DxToAddAndSub, "DX");
                                break;

                            default:
                                break;
                        }
                        break;
                    }
                }

                else
                {
                    break;
                }
            }
        }

        //Method that triggers further actions for choosen registry. SelectedRegistry is registry you've choosen. Second,Third and Fourth are the next ones
        //in alphabetical order. For Example if Choosen Registry is Bx, Bx registry is "Selected Registry" And then SecondRegistry is AX, ThirdRegistry is CX
        //and so on. In first step, user chooses registry he wanna substract from another. Constructors of the following methods are based on those constructors bellow.

        public static void ChoosenRegistryToSubstractMethod(ref string SelectedRegistry, ref int FirstRegistryAuxiliaryInt, string FirstRegistryNameToMessages,
            ref string SecondRegistry, ref int SecondRegistryAuxiliaryInt, string SecondRegistryNameToMessages,
            ref string ThirdRegistry, ref int ThirdRegistryAuxiliaryInt, string ThirdRegistryNameToMessages,
            ref string FourthRegistry, ref int FourthRegistryAuxiliaryInt, string FourthRegistryNameToMessages)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine($"You have choosen {FirstRegistryNameToMessages} registry.Select registry you want to be substracted by {FirstRegistryNameToMessages}: \n");
            Console.ResetColor();

            Console.WriteLine($"(1) {SecondRegistryNameToMessages}\n");
            Console.WriteLine($"(2) {ThirdRegistryNameToMessages}\n");
            Console.WriteLine($"(3) {FourthRegistryNameToMessages}\n");

            int.TryParse(Console.ReadLine(), out int RegistryToBeSubstracted);

            if (RegistryToBeSubstracted == 1)
            {
                RegistryToBeSubstractedMethod(ref FirstRegistryAuxiliaryInt, FirstRegistryNameToMessages, ref SecondRegistry, ref SecondRegistryAuxiliaryInt, SecondRegistryNameToMessages);
            }
            if (RegistryToBeSubstracted == 2)
            {
                RegistryToBeSubstractedMethod(ref FirstRegistryAuxiliaryInt, FirstRegistryNameToMessages, ref ThirdRegistry, ref ThirdRegistryAuxiliaryInt, ThirdRegistryNameToMessages);
            }
            if (RegistryToBeSubstracted == 3)
            {
                RegistryToBeSubstractedMethod(ref FirstRegistryAuxiliaryInt, FirstRegistryNameToMessages, ref FourthRegistry, ref FourthRegistryAuxiliaryInt, FourthRegistryNameToMessages);
            }
        }

        //Method that checks if both choosen registries store numbers.If so,substraction is being made

        public static void RegistryToBeSubstractedMethod(ref int FirstRegistryAuxiliaryIntValue, string FirstRegistryNameToMessages,
            ref string RegistryToBeingSubstracted, ref int SecondRegistryAuxiliaryIntValue, string SecondRegistryNameToMessages)
        {
            //if both registries store numbers
            if (FirstRegistryAuxiliaryIntValue != 0 && SecondRegistryAuxiliaryIntValue != 0)
            {
                if (Enumerable.Range(-32767, 65535).Contains(SecondRegistryAuxiliaryIntValue - FirstRegistryAuxiliaryIntValue))
                {
                    Console.Clear();

                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("Substraction process is about to begin\n");
                    Console.ResetColor();

                    RegistryToBeingSubstracted = DecToHex.DecimalToHexadecimal(SecondRegistryAuxiliaryIntValue - FirstRegistryAuxiliaryIntValue);
                    SecondRegistryAuxiliaryIntValue -= FirstRegistryAuxiliaryIntValue;

                    PleaseWait.Wait();

                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine($"\nSuccess! {FirstRegistryNameToMessages} registry value has been successfully substracted from {SecondRegistryNameToMessages} registry value. Press any key to return.");
                    Console.ResetColor();
                    Console.ReadLine();
                    Program.Main();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("\nAfter Substraction final number will exceed 16 bits. Please press any key to try again!");
                    Console.ResetColor();
                    Console.ReadLine();
                    SUB();
                }
            }

            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\nYou can substract numbers only. Press any key to try again");
                Console.ResetColor();
                Console.ReadLine();
                SUB();
            }
        }

        //Method which substract given number from choosen registry

        public static void ChoosenRegistryToSubNumber(ref string RegistryToDisplayOnDashBoard, ref int ItsAuxiliaryIntValue, string RegistryStringToDisplayMessages)
        {
            while (true)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine($"You have choosen {RegistryStringToDisplayMessages} registry. Please enter number you want to substract from {RegistryStringToDisplayMessages}: \n");
                Console.ResetColor();

                string Value = Console.ReadLine();
                bool isNumber = int.TryParse(Value, out int EnteredValue);

                //Checks if given value is a number.
                //If so, substraction is being made.
                //If not, substraction can't be processed.
                if (isNumber)
                {
                    bool isAxRegistryNumber = true;

                    //handling 0 being displayed on start when program opened
                    if (RegistryToDisplayOnDashBoard == 0.ToString())
                        isAxRegistryNumber = int.TryParse(RegistryToDisplayOnDashBoard, out int variable);

                    //reggistry which store string or string stored as bits of information
                    if (RegistryToDisplayOnDashBoard != 0.ToString() && ItsAuxiliaryIntValue == 0)
                    {
                        isAxRegistryNumber = false;
                    }

                    if (isAxRegistryNumber)
                    {
                        Console.Clear();
                        if (Enumerable.Range(-32767, 65535).Contains(ItsAuxiliaryIntValue - EnteredValue))
                        {
                            Console.Clear();

                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            Console.WriteLine("Substraction process is about to begin\n");
                            Console.ResetColor();

                            RegistryToDisplayOnDashBoard = DecToHex.DecimalToHexadecimal(ItsAuxiliaryIntValue - EnteredValue);
                            ItsAuxiliaryIntValue -= EnteredValue;

                            PleaseWait.Wait();

                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine($"\nSuccess! Given number has been successfully substracted from {RegistryStringToDisplayMessages} registry value. Press any key to return.");
                            Console.ResetColor();
                            Console.ReadLine();
                            Program.Main();
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("\nAfter Substraction final number will exceed 16 bits. Please press any key to try again!");
                            Console.ResetColor();
                            Console.ReadLine();
                            SUB();
                        }
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("\nYou can substract numbers only. Press any key to try again. Press any key to try again");
                        Console.ResetColor();
                        Console.ReadLine();
                        SUB();
                    }
                }
            }
        }
    }
}
