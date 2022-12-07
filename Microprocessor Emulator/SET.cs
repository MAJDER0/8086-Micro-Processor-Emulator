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

                    if (ChoosenRegistry == 1)
                    {
                        while (true)
                        {

                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            Console.WriteLine("\nYou have choosen AX Registry, what you wanna enter? \n");
                            Console.ResetColor();
                            Console.WriteLine("(1) number\n");
                            Console.WriteLine("(2) string\n");
                            Console.WriteLine("(3) string stored as bit of informations\n");
                            Console.WriteLine("\n() Any other key to return menu\n");

                            int ChoosenOperation = int.Parse(Console.ReadLine());

                            if (ChoosenOperation == 1)
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

                                        Registries.AxValue = AxToHex;
                                        Registries.AxToAddAndSub = AxResult;
                                        Registries.AxValueStringOnly = 0.ToString();

                                        PleaseWait.Wait();

                                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                                        Console.WriteLine("\nSuccess! Press any key to return");
                                        Console.ResetColor();
                                        Console.ReadLine();
                                        break;

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

                            if (ChoosenOperation == 2)
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

                                    foreach (var znak in AxResultstr)
                                    {
                                        count++;
                                    }

                                    if (count < 16)
                                    {
                                        Registries.AxValue = AxResultstr;
                                        Registries.AxToAddAndSub = 0;
                                        Registries.AxValueStringOnly = AxResultstr;

                                        PleaseWait.Wait();

                                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                                        Console.WriteLine("\nSuccess! Press any key to return");
                                        Console.ResetColor();
                                        Console.ReadLine();
                                        break;
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

                            if (ChoosenOperation == 3)
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                Console.WriteLine("\nPlease enter string: \n");
                                Console.ResetColor();

                                string AxResultstr = Console.ReadLine();
                                bool isNumber = int.TryParse(AxResultstr, out int AxResult);

                                if (!isNumber)
                                {
                                    var result = TextToHex.AsciiToHex(AxResultstr);

                                    bool isResultSixteenBits = ushort.TryParse(result, out ushort SixteenBitsResult);

                                    if (isResultSixteenBits)
                                    {
                                        Registries.AxValue = result;
                                        Registries.AxToAddAndSub = 0;
                                        Registries.AxValueStringOnly = 0.ToString();

                                        PleaseWait.Wait();

                                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                                        Console.WriteLine("\nSuccess! Press any key to return");
                                        Console.ResetColor();
                                        Console.ReadLine();
                                        break;
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
                                    Console.WriteLine("\nPlease enter string\n!");
                                    Console.ResetColor();
                                    Console.ReadLine();
                                    continue;
                                }
                            }
                        }
                        break;
                    }

                    if (ChoosenRegistry == 2)
                    {
                        while (true)
                        {


                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            Console.WriteLine("\nYou have choosen BX Registry, what you wanna enter? \n");
                            Console.ResetColor();
                            Console.WriteLine("(1) number\n");
                            Console.WriteLine("(2) string\n");
                            Console.WriteLine("(3) string stored as bit of informations\n");
                            Console.WriteLine("\n() Any other key to return menu\n");

                            int ChoosenOperation = int.Parse(Console.ReadLine());

                            if (ChoosenOperation == 1)
                            {

                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                Console.WriteLine("\nPlease enter number: \n");
                                Console.ResetColor();

                                bool isNumber = int.TryParse(Console.ReadLine(), out int BxResult);

                                if (isNumber)
                                {

                                    if (Enumerable.Range(-32767, 65535).Contains(BxResult))
                                    {
                                        var BxToHex = DecToHex.DecimalToHexadecimal(BxResult);

                                        Registries.BxValue = BxToHex;
                                        Registries.BxToAddAndSub = BxResult;
                                        Registries.BxValueStringOnly = 0.ToString();

                                        PleaseWait.Wait();

                                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                                        Console.WriteLine("\nSuccess! Press any key to return");
                                        Console.ResetColor();
                                        Console.ReadLine();
                                        break;

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

                            if (ChoosenOperation == 2)
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                Console.WriteLine("\nPlease enter string: \n");
                                Console.ResetColor();

                                string BxResultstr = Console.ReadLine();
                                bool isNumber = int.TryParse(BxResultstr, out int BxResult);

                                if (!isNumber)
                                {
                                    int count = 0;

                                    foreach (var znak in BxResultstr)
                                    {
                                        count++;
                                    }

                                    if (count < 16)
                                    {
                                        Registries.BxValue = BxResultstr;
                                        Registries.BxToAddAndSub = 0;
                                        Registries.BxValueStringOnly = BxResultstr;

                                        PleaseWait.Wait();

                                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                                        Console.WriteLine("\nSuccess! Press any key to return");
                                        Console.ResetColor();
                                        Console.ReadLine();
                                        break;
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

                            if (ChoosenOperation == 3)
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                Console.WriteLine("\nPlease enter string: \n");
                                Console.ResetColor();

                                string BxResultstr = Console.ReadLine();
                                bool isNumber = int.TryParse(BxResultstr, out int BxResult);

                                if (!isNumber)
                                {
                                    var result = TextToHex.AsciiToHex(BxResultstr);

                                    bool isResultSixteenBits = ushort.TryParse(result, out ushort SixteenBitsResult);

                                    if (isResultSixteenBits)
                                    {
                                        Registries.BxValue = result;
                                        Registries.BxToAddAndSub = 0;
                                        Registries.BxValueStringOnly = 0.ToString();

                                        PleaseWait.Wait();

                                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                                        Console.WriteLine("\nSuccess! Press any key to return");
                                        Console.ResetColor();
                                        Console.ReadLine();
                                        break;
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
                                    Console.WriteLine("\nPlease enter string\n!");
                                    Console.ResetColor();
                                    Console.ReadLine();
                                    continue;
                                }
                            }
                        }
                        break;
                    }

                    if (ChoosenRegistry == 3)
                    {
                        while (true)
                        {

                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            Console.WriteLine("\nYou have choosen CX Registry, what you wanna enter? \n");
                            Console.ResetColor();
                            Console.WriteLine("(1) number\n");
                            Console.WriteLine("(2) string\n");
                            Console.WriteLine("(3) string stored as bit of informations\n");
                            Console.WriteLine("\n() Any other key to return menu\n");

                            int ChoosenOperation = int.Parse(Console.ReadLine());

                            if (ChoosenOperation == 1)
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                Console.WriteLine("\nPlease enter number: \n");
                                Console.ResetColor();

                                bool isNumber = int.TryParse(Console.ReadLine(), out int CxResult);

                                if (isNumber)
                                {
                                    if (Enumerable.Range(-32767, 65535).Contains(CxResult))
                                    {
                                        var CxToHex = DecToHex.DecimalToHexadecimal(CxResult);

                                        Registries.CxValue = CxToHex;
                                        Registries.CxToAddAndSub = CxResult;
                                        Registries.CxValueStringOnly = 0.ToString();

                                        PleaseWait.Wait();

                                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                                        Console.WriteLine("\nSuccess! Press any key to return");
                                        Console.ResetColor();
                                        Console.ReadLine();
                                        break;

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

                            if (ChoosenOperation == 2)
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                Console.WriteLine("\nPlease enter string: \n");
                                Console.ResetColor();

                                string CxResultstr = Console.ReadLine();
                                bool isNumber = int.TryParse(CxResultstr, out int CxResult);

                                if (!isNumber)
                                {
                                    int count = 0;

                                    foreach (var znak in CxResultstr)
                                    {
                                        count++;
                                    }

                                    if (count < 16)
                                    {
                                        Registries.CxValue = CxResultstr;
                                        Registries.CxToAddAndSub = 0;
                                        Registries.CxValueStringOnly = CxResultstr;

                                        PleaseWait.Wait();

                                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                                        Console.WriteLine("\nSuccess! Press any key to return");
                                        Console.ResetColor();
                                        Console.ReadLine();
                                        break;
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

                            if (ChoosenOperation == 3)
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                Console.WriteLine("\nPlease enter string: \n");
                                Console.ResetColor();

                                string CxResultstr = Console.ReadLine();
                                bool isNumber = int.TryParse(CxResultstr, out int CxResult);

                                if (!isNumber)
                                {
                                    var result = TextToHex.AsciiToHex(CxResultstr);

                                    bool isResultSixteenBits = ushort.TryParse(result, out ushort SixteenBitsResult);

                                    if (isResultSixteenBits)
                                    {
                                        Registries.CxValue = result;
                                        Registries.CxToAddAndSub = 0;
                                        Registries.CxValueStringOnly = 0.ToString();

                                        PleaseWait.Wait();

                                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                                        Console.WriteLine("\nSuccess! Press any key to return");
                                        Console.ResetColor();
                                        Console.ReadLine();
                                        break;
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
                                    Console.WriteLine("\nPlease enter string\n!");
                                    Console.ResetColor();
                                    Console.ReadLine();
                                    continue;
                                }
                            }
                        }
                        break;
                    }

                    if (ChoosenRegistry == 4)
                    {
                        while (true)
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            Console.WriteLine("\nYou have choosen DX Registry, what you wanna enter? \n");
                            Console.ResetColor();
                            Console.WriteLine("(1) number\n");
                            Console.WriteLine("(2) string\n");
                            Console.WriteLine("(3) string stored as bit of informations\n");
                            Console.WriteLine("\n() Any other key to return menu\n");

                            int ChoosenOperation = int.Parse(Console.ReadLine());

                            if (ChoosenOperation == 1)
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                Console.WriteLine("\nPlease enter number: \n");
                                Console.ResetColor();

                                bool isNumber = int.TryParse(Console.ReadLine(), out int DxResult);

                                if (isNumber)
                                {

                                    if (Enumerable.Range(-32767, 65535).Contains(DxResult))
                                    {
                                        var DxToHex = DecToHex.DecimalToHexadecimal(DxResult);

                                        Registries.DxValue = DxToHex;
                                        Registries.DxToAddAndSub = DxResult;
                                        Registries.DxValueStringOnly = 0.ToString();

                                        PleaseWait.Wait();

                                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                                        Console.WriteLine("\nSuccess! Press any key to return");
                                        Console.ResetColor();
                                        Console.ReadLine();
                                        break;
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

                            if (ChoosenOperation == 2)
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                Console.WriteLine("\nPlease enter string: \n");
                                Console.ResetColor();

                                string DxResultstr = Console.ReadLine();
                                bool isNumber = int.TryParse(DxResultstr, out int DxResult);

                                if (!isNumber)
                                {
                                    int count = 0;

                                    foreach (var znak in DxResultstr)
                                    {
                                        count++;
                                    }

                                    if (count < 16)
                                    {
                                        Registries.DxValue = DxResultstr;
                                        Registries.DxToAddAndSub = 0;
                                        Registries.DxValueStringOnly = DxResultstr;

                                        PleaseWait.Wait();

                                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                                        Console.WriteLine("\nSuccess! Press any key to return");
                                        Console.ResetColor();
                                        Console.ReadLine();
                                        break;
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

                            if (ChoosenOperation == 3)
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                Console.WriteLine("\nPlease enter string: \n");
                                Console.ResetColor();

                                string DxResultstr = Console.ReadLine();
                                bool isNumber = int.TryParse(DxResultstr, out int DxResult);

                                if (!isNumber)
                                {
                                    var result = TextToHex.AsciiToHex(DxResultstr);

                                    bool isResultSixteenBits = ushort.TryParse(result, out ushort SixteenBitsResult);

                                    if (isResultSixteenBits)
                                    {
                                        Registries.DxValue = result;
                                        Registries.DxToAddAndSub = 0;
                                        Registries.DxValueStringOnly = 0.ToString();

                                        PleaseWait.Wait();

                                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                                        Console.WriteLine("\nSuccess! Press any key to return");
                                        Console.ResetColor();
                                        Console.ReadLine();
                                        break;
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
                                    Console.WriteLine("\nPlease enter string\n!");
                                    Console.ResetColor();
                                    Console.ReadLine();
                                    continue;
                                }
                            }
                        }
                        break;
                    }
                    else
                    {
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

            }
        }
    }
}
