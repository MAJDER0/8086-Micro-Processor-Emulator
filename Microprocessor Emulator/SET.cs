using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

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
                            Console.WriteLine("\nYou have choosen AX Registry, please enter value now: \n");
                            Console.ResetColor();

                            string AxResultstr = Console.ReadLine();
                            bool isNumber = int.TryParse(AxResultstr, out int AxResult);

                            if (isNumber)
                            {

                                if (Enumerable.Range(-32767, 65535).Contains(AxResult))
                                {
                                    var AxToHex = DecToHex.DecimalToHexadecimal(AxResult);
                                    Registries.AxValue = AxToHex;
                                    Registries.AxToAddAndSub = AxResult;

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

                                var result = TextToHex.AsciiToHex(AxResultstr);

                                bool isResultSixteenBits = ushort.TryParse(result, out ushort SixteenBitsResult);

                                if (isResultSixteenBits)
                                {
                                    Registries.AxValue = result;
                                    Registries.AxToAddAndSub = 0;

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

                        }
                        break;
                    }

                    if (ChoosenRegistry == 2)
                    {
                        while (true)
                        {


                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            Console.WriteLine("\nYou have choosen BX Registry, please enter value now: \n");
                            Console.ResetColor();

                            string BxResultstr = Console.ReadLine();
                            bool isNumber = int.TryParse(BxResultstr, out int BxResult);

                            if (isNumber)
                            {

                                if (Enumerable.Range(-32767, 65535).Contains(BxResult))
                                {
                                    var BxToHex = DecToHex.DecimalToHexadecimal(BxResult);
                                    Registries.BxValue = BxToHex;
                                    Registries.BxToAddAndSub = BxResult;

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

                                var result = TextToHex.AsciiToHex(BxResultstr);

                                bool isResultSixteenBits = ushort.TryParse(result, out ushort SixteenBitsResult);

                                if (isResultSixteenBits)
                                {

                                    Registries.BxValue = result;
                                    Registries.BxToAddAndSub = 0;

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
                        }

                        break;
                    }


                    if (ChoosenRegistry == 3)
                    {
                        while (true)
                        {


                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            Console.WriteLine("\nYou have choosen CX Registry, please enter value now: \n");
                            Console.ResetColor();

                            string CxResultstr = Console.ReadLine();
                            bool isNumber = int.TryParse(CxResultstr, out int CxResult);

                            if (isNumber)
                            {

                                if (Enumerable.Range(-32767, 65535).Contains(CxResult))
                                {
                                    var CxToHex = DecToHex.DecimalToHexadecimal(CxResult);
                                    Registries.CxValue = CxToHex;
                                    Registries.CxToAddAndSub = CxResult;

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
                                var result = TextToHex.AsciiToHex(CxResultstr);

                                bool isResultSixteenBits = ushort.TryParse(result, out ushort SixteenBitsResult);
                                if (isResultSixteenBits)
                                {
                                    Registries.CxValue = result;
                                    Registries.CxToAddAndSub = 0;

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
                        }

                        break;
                    }





                    if (ChoosenRegistry == 4)
                    {
                        while (true)
                        {


                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            Console.WriteLine("\nYou have choosen DX Registry, please enter value now: \n");
                            Console.ResetColor();

                            string DxResultstr = Console.ReadLine();
                            bool isNumber = int.TryParse(DxResultstr, out int DxResult);


                            if (isNumber)
                            {

                                if (Enumerable.Range(-32767, 65535).Contains(DxResult))
                                {
                                    var DxToHex = DecToHex.DecimalToHexadecimal(DxResult);
                                    Registries.DxValue = DxToHex;
                                    Registries.DxToAddAndSub = DxResult;

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
                                var result = TextToHex.AsciiToHex(DxResultstr);

                                bool isResultSixteenBits = ushort.TryParse(result, out ushort SixteenBitsResult);

                                if (isResultSixteenBits)
                                {
                                    Registries.DxValue = result;
                                    Registries.DxToAddAndSub = 0;

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
