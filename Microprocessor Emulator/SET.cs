using System;
using System.Collections.Generic;
using System.Linq;
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
                Console.WriteLine("\n(5) Return Menu\n");

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
                                    Registries.AxValue = AxResult;

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
                                string result = AxResultstr;

                                Registries.AxValueStr = AxResultstr;

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

                            if(isNumber)
                            {

                                if (Enumerable.Range(-32767, 65535).Contains(BxResult))
                                {
                                    Registries.BxValue = BxResult;

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

                                string result = BxResultstr;

                                Registries.BxValueStr = BxResultstr;

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

                            if(isNumber)
                            {

                                if (Enumerable.Range(-32767, 65535).Contains(CxResult))
                                {
                                    Registries.CxValue = CxResult;

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

                                string result = CxResultstr;

                                Registries.CxValueStr = CxResultstr;

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

                            if(isNumber)
                            {

                                if (Enumerable.Range(-32767, 65535).Contains(DxResult))
                                {
                                    Registries.DxValue = DxResult;

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

                                string result = DxResultstr;

                                Registries.DxValueStr = DxResultstr;

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
                        }

                        break;
                    }

                    if (ChoosenRegistry == 5)
                    {
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
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Please choose correctly\n");
                    Console.ResetColor();
                    Console.ReadLine();
                    Console.Clear();
                    continue;
                }

            }
        }
    }
}
