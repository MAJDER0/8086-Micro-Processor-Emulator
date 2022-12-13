using Microprocessor_Emualtor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
                Console.WriteLine("\n() Any key to return\n");

                int.TryParse(Console.ReadLine(), out int TriggerAction);

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

                    int.TryParse(Console.ReadLine(), out int ChoosenRegistry);
                    switch (ChoosenRegistry)
                    {
                        case 1:
                            ChoosenFirstRegistry(ref Registries.AxValue, ref Registries.AxToAddAndSub, ref Registries.AxValueStringOnly, "AX",
                              ref Registries.BxValue, ref Registries.BxToAddAndSub, ref Registries.BxValueStringOnly, "BX",
                                 ref Registries.CxValue, ref Registries.CxToAddAndSub, ref Registries.CxValueStringOnly, "CX",
                                     ref Registries.DxValue, ref Registries.DxToAddAndSub, ref Registries.DxValueStringOnly, "DX");
                            break;

                        case 2:
                            ChoosenFirstRegistry(ref Registries.BxValue, ref Registries.BxToAddAndSub, ref Registries.BxValueStringOnly, "BX",
                              ref Registries.AxValue, ref Registries.AxToAddAndSub, ref Registries.AxValueStringOnly, "AX",
                                 ref Registries.CxValue, ref Registries.CxToAddAndSub, ref Registries.CxValueStringOnly, "CX",
                                     ref Registries.DxValue, ref Registries.DxToAddAndSub, ref Registries.DxValueStringOnly, "DX");
                            break;

                        case 3:
                            ChoosenFirstRegistry(ref Registries.CxValue, ref Registries.CxToAddAndSub, ref Registries.CxValueStringOnly, "CX",
                              ref Registries.AxValue, ref Registries.AxToAddAndSub, ref Registries.AxValueStringOnly, "AX",
                                ref Registries.BxValue, ref Registries.BxToAddAndSub, ref Registries.BxValueStringOnly, "BX",
                                    ref Registries.DxValue, ref Registries.DxToAddAndSub, ref Registries.DxValueStringOnly, "DX");
                            break;

                        case 4:
                            ChoosenFirstRegistry(ref Registries.DxValue, ref Registries.DxToAddAndSub, ref Registries.DxValueStringOnly, "DX",
                              ref Registries.AxValue, ref Registries.AxToAddAndSub, ref Registries.AxValueStringOnly, "AX",
                                 ref Registries.BxValue, ref Registries.BxToAddAndSub, ref Registries.BxValueStringOnly, "BX",
                                     ref Registries.CxValue, ref Registries.CxToAddAndSub, ref Registries.CxValueStringOnly, "CX");
                            break;

                        default:
                            break;
                    }
                }

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
                        int.TryParse(Console.ReadLine(), out int ChoosenRegistry);

                        switch (ChoosenRegistry)
                        {

                            case 1:
                                ChoosenRegistryToAddValue(ref Registries.AxValue, ref Registries.AxToAddAndSub, ref Registries.AxValueStringOnly, "AX");
                                break;

                            case 2:
                                ChoosenRegistryToAddValue(ref Registries.BxValue, ref Registries.BxToAddAndSub, ref Registries.BxValueStringOnly, "BX");
                                break;

                            case 3:
                                ChoosenRegistryToAddValue(ref Registries.CxValue, ref Registries.CxToAddAndSub, ref Registries.CxValueStringOnly, "CX");
                                break;

                            case 4:
                                ChoosenRegistryToAddValue(ref Registries.DxValue, ref Registries.DxToAddAndSub, ref Registries.DxValueStringOnly, "DX");
                                break;

                            default:
                                break;
                        }
                        break;
                    }
                }

                else
                {
                    Program.Main();
                }
            }
        }

        //Method that triggers further actions for choosen registry. SelectedRegistry is registry you've choosen. Second, Third and Fourth are the next ones
        //in alphabetical order. For Example if Choosen Registry is Bx, Bx registry is "Selected Registry" And then SecondRegistry is AX, ThirdRegistry is CX
        //and so on. In First, user chooses registry that Its value gonna be added to next selected one. Constructors of the following methods are based on those constructors bellow.

        public static void ChoosenFirstRegistry(ref string SelectedRegistry, ref int FirstRegistryAuxiliaryInt, ref string FirstRegistryAuxiliaryString, string FirstRegistryNameToMessages,
            ref string SecondRegistry, ref int SecondRegistryAuxiliaryInt, ref string SecondRegistryAuxiliaryString, string SecondRegistryNameToMessages,
            ref string ThirdRegistry, ref int ThirdRegistryAuxiliaryInt, ref string ThirdRegistryAuxiliaryString, string ThirdRegistryNameToMessages,
            ref string FourthRegistry, ref int FourthRegistryAuxiliaryInt, ref string FourthRegistryAuxiliaryString, string FourthRegistryNameToMessages)
        {

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine($"You have choosen {FirstRegistryNameToMessages} registry.Select registry you wanna add {FirstRegistryNameToMessages} to: \n");
            Console.ResetColor();

            Console.WriteLine($"(1) {SecondRegistryNameToMessages}\n");
            Console.WriteLine($"(2) {ThirdRegistryNameToMessages}\n");
            Console.WriteLine($"(3) {FourthRegistryNameToMessages}\n");

            int.TryParse(Console.ReadLine(), out int SelectedRegistryToAdd);

            switch (SelectedRegistryToAdd)
            {
                case 1:
                    SelectedRegistryAddition(SelectedRegistry, FirstRegistryAuxiliaryInt, FirstRegistryAuxiliaryString, FirstRegistryNameToMessages,
                        ref SecondRegistry, ref SecondRegistryAuxiliaryInt, ref SecondRegistryAuxiliaryString, SecondRegistryNameToMessages);
                    break;

                case 2:
                    SelectedRegistryAddition(SelectedRegistry, FirstRegistryAuxiliaryInt, FirstRegistryAuxiliaryString, FirstRegistryNameToMessages,
                        ref ThirdRegistry, ref ThirdRegistryAuxiliaryInt, ref ThirdRegistryAuxiliaryString, ThirdRegistryNameToMessages);
                    break;

                case 3:
                    SelectedRegistryAddition(SelectedRegistry, FirstRegistryAuxiliaryInt, FirstRegistryAuxiliaryString, FirstRegistryNameToMessages,
                        ref FourthRegistry, ref FourthRegistryAuxiliaryInt, ref FourthRegistryAuxiliaryString, FourthRegistryNameToMessages);
                    break;

            }

        }

        //Method checks if the first and second choosen registry stores number, string or string stores as bits of information.
        //When First and Second registry dont store the same type of value, error to be displayed. Please check out Registries class
        //if you want to make given below if statements more clear

        public static void SelectedRegistryAddition(string RegistryYouChoosenToAdd, int FirstIntAuxiliaryValue, string FirstStringAuxiliaryValue, string DisplayingFirstsName,
            ref string SelectedRegistryToAdd, ref int SecondIntAuxiliaryValue, ref string SecondStringAuxiliaryValue, string DisplayingSecondsName)
        {
            //When First and Second Registry are both number do if
            if (FirstIntAuxiliaryValue != 0 && SecondIntAuxiliaryValue != 0)
            {
                EnumerableRange(RegistryYouChoosenToAdd, FirstIntAuxiliaryValue, DisplayingFirstsName,
                    ref SelectedRegistryToAdd, ref SecondIntAuxiliaryValue, DisplayingSecondsName);
            }

            //When both registries dont store either number or string stored as bits of information, it means that both registries store string
            //So basically: when both registries are strings
            if (FirstIntAuxiliaryValue == 0 && SecondIntAuxiliaryValue == 0 && FirstStringAuxiliaryValue != 0.ToString() && SecondStringAuxiliaryValue != 0.ToString())
            {
                AddNormalStrings(RegistryYouChoosenToAdd, FirstStringAuxiliaryValue, DisplayingFirstsName,
                    ref SelectedRegistryToAdd, ref SecondStringAuxiliaryValue, DisplayingSecondsName);
            }

            //When both registries store strings stored as bits of information
            if (FirstIntAuxiliaryValue == 0 && SecondIntAuxiliaryValue == 0 && FirstStringAuxiliaryValue == 0.ToString() && SecondStringAuxiliaryValue == 0.ToString())
            {
                StringsAsBitOfInformationsAddition(RegistryYouChoosenToAdd, DisplayingFirstsName,
                    ref SelectedRegistryToAdd, DisplayingSecondsName);
            }

            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\nYou can't add string-to-number, number-to-string or string stored as bits of information (SABOI) to casual string or number. Please add number-to-number, string-to-string or (SABI)string-to-(SABI)string. Press any key to try again");
                Console.ResetColor();
                Console.ReadLine();
                ADD();
            }
        }

        //Addition of regs numeric values. 

        public static void EnumerableRange(string NameOfFirstRegAndDisplayingItOnDashBoard, int FirstRegValue, string FirstRegistryStringToDisplayMessages,
            ref string NameOfSecondRegAndDisplayingItOnDashBoard, ref int SecondRegValue, string SecondRegistryStringToDisplayMessages)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine($"\nYou have choosen {SecondRegistryStringToDisplayMessages} Registry, adding process is about to begin");
            Console.ResetColor();

            if (Enumerable.Range(-32767, 65535).Contains((FirstRegValue + SecondRegValue)))
            {

                NameOfSecondRegAndDisplayingItOnDashBoard = DecToHex.DecimalToHexadecimal((FirstRegValue + SecondRegValue));
                SecondRegValue += FirstRegValue;

                PleaseWait.Wait();

                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine($"\nSuccess! {FirstRegistryStringToDisplayMessages} registry value has been successfully added to {SecondRegistryStringToDisplayMessages} registry value. Press any key to return.");
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
                ADD();
            }
        }

        // Normal Strings Addition 

        public static void AddNormalStrings(string NameOfFirstRegAndDisplayingItOnDashBoard, string FirstGivenString, string FirstRegistryStringToDisplayMessages,
            ref string NameOfSecondRegAndDisplayingItOnDashBoard, ref string SecondGivenString, string SecondRegistryStringToDisplayMessages)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine($"You have choosen {SecondRegistryStringToDisplayMessages} Registry, adding process is about to begin");
            Console.ResetColor();

            string AddedValues = SecondGivenString + FirstGivenString;

            int counter = 0;

            foreach (var item in AddedValues)
            {
                counter++;
            }

            if (counter < 16)
            {

                NameOfSecondRegAndDisplayingItOnDashBoard = AddedValues;
                SecondGivenString = AddedValues;

                PleaseWait.Wait();

                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine($"\nSuccess! {FirstRegistryStringToDisplayMessages} registry value has been successfully added to {SecondRegistryStringToDisplayMessages} registry value. Press any key to return.");
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
                ADD();
            }
        }

        //Adding strings stored as bits of information

        public static void StringsAsBitOfInformationsAddition(string NameOfFirstRegAndDisplayingItOnDashBoard, string FirstRegistryStringToDisplayMessages,
            ref string NameOfSecondRegAndDisplayingItOnDashBoard, string SecondRegistryStringToDisplayMessages)
        {

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine($"You have choosen {SecondRegistryStringToDisplayMessages} Registry, adding process is about to begin");
            Console.ResetColor();

            //Concatenating two hex numbers to check if they're 16-bits
            string AddedValues = NameOfSecondRegAndDisplayingItOnDashBoard + NameOfFirstRegAndDisplayingItOnDashBoard;

            bool isResultSixteenBits = ushort.TryParse(AddedValues, out ushort SixteenBitsResult);

            if (isResultSixteenBits)
            {
                NameOfSecondRegAndDisplayingItOnDashBoard = AddedValues;

                PleaseWait.Wait();

                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine($"\nSuccess! {FirstRegistryStringToDisplayMessages} registry value has been successfully added to {SecondRegistryStringToDisplayMessages} registry value. Press any key to return.");
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
                ADD();
            }

        }

        // Adds Given Value to Choosen Registry

        public static void ChoosenRegistryToAddValue(ref string RegistryToDisplayOnDashBoard, ref int ItsAuxiliaryIntValue, ref string ItsAuxiliaryStringValue, string RegistryStringToDisplayMessages)
        {

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine($"You have choosen {RegistryStringToDisplayMessages} registry. Please enter number or word you wanna add to {RegistryStringToDisplayMessages}: \n");
            Console.ResetColor();

            string Value = Console.ReadLine();
            bool isNumber = int.TryParse(Value, out int EnteredValue);

            if (isNumber)
            {
                bool isAxRegistryNumber = true;

                //If the value displayed on dashboard is equal 0,
                //we want to Parse this value into int, so we can add it with given number  
                if (RegistryToDisplayOnDashBoard == 0.ToString())
                    isAxRegistryNumber = int.TryParse(RegistryToDisplayOnDashBoard, out int variable);

                //When there is registry value displayed on dashboard but its Int value is equal 0,
                //It means that choosen registry doesnt store a number
                if (RegistryToDisplayOnDashBoard != 0.ToString() && ItsAuxiliaryIntValue == 0)
                {
                    isAxRegistryNumber = false;
                }

                if (isAxRegistryNumber)
                {
                    Console.Clear();
                    if (Enumerable.Range(-32767, 65535).Contains((ItsAuxiliaryIntValue + EnteredValue)))
                    {
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine("Adding process is about to begin");
                        Console.ResetColor();

                        RegistryToDisplayOnDashBoard = DecToHex.DecimalToHexadecimal((ItsAuxiliaryIntValue + EnteredValue));
                        ItsAuxiliaryIntValue += EnteredValue;

                        PleaseWait.Wait();

                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine($"\nSuccess! Entered value has been successfully added to {RegistryStringToDisplayMessages} registry. Press any key to return.");
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
                        ADD();
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("\nYou can't exceed 16 bits and add null, string-to-number, number-to-string or string stored as bits of information (SABOI) to casual string or number. Please add number-to-number, string-to-string or (SABI)string-to-(SABI)string. Press any key to try again");
                    Console.ResetColor();
                    Console.ReadLine();
                    ADD();
                }
            }

            if (!isNumber)
            {
                bool isAxRegistryNumber = false;

                //When Auxiliary Int Value is not equal 0,
                //it means that registry stores number.            
                if (ItsAuxiliaryIntValue != 0)
                {
                    isAxRegistryNumber = true;
                }

                //When opened program, Default value is 0,
                //We consider this situation with if.
                if (RegistryToDisplayOnDashBoard == 0.ToString())
                {
                    isAxRegistryNumber = true;
                }

                //when choosen registry doesnt store number,doesn't store normal string (ItsAuxiliaryStringValue)
                //and there's anything to be displayed on dashboard, it means that registry we want to add the value,
                //stores string stored as bits of information.
                if (!isAxRegistryNumber && RegistryToDisplayOnDashBoard != 0.ToString() && ItsAuxiliaryStringValue == 0.ToString())
                {

                    string AddedValues = RegistryToDisplayOnDashBoard + TextToHex.AsciiToHex(Value);

                    //checks if given value after converting to hex + current registry value, will exceed 16-bits
                    bool isResultSixteenBits = ushort.TryParse(AddedValues, out ushort SixteenBitsResult);

                    if (isResultSixteenBits)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine("Adding process is about to begin");
                        Console.ResetColor();

                        RegistryToDisplayOnDashBoard = AddedValues;

                        PleaseWait.Wait();

                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine($"\nSuccess! Entered value has been successfully added to {RegistryStringToDisplayMessages} registry. Press any key to return.");
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
                        ADD();
                    }
                }

                //when choosen registry doesnt store number, but ItsAuxiliaryStringValue != 0.ToString(),
                //It means that registry stores a string.
                if (!isAxRegistryNumber && RegistryToDisplayOnDashBoard != 0.ToString() && ItsAuxiliaryStringValue != 0.ToString())
                {

                    string AddedValues = RegistryToDisplayOnDashBoard + Value;

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

                        RegistryToDisplayOnDashBoard = AddedValues;
                        ItsAuxiliaryStringValue = AddedValues;

                        PleaseWait.Wait();

                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine($"\nSuccess! Entered value has been successfully added to {RegistryStringToDisplayMessages} registry. Press any key to return.");
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
                        ADD();
                    }
                }

                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("\nYou can't exceed 16 bits and add null, string-to-number, number-to-string or string stored as bits of information (SABOI) to casual string or number. Please add number-to-number, string-to-string or (SABI)string-to-(SABI)string. Press any key to try again");
                    Console.ResetColor();
                    Console.ReadLine();
                    ADD();
                }
            }
        }
    }

}

