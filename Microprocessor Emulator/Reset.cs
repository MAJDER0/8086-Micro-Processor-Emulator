using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microprocessor_Emulator
{
    public class Reset
    {
        public static void ResetValues()
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("Which Registry you want to reset?\n");
                Console.ResetColor();

                Console.WriteLine("(1) AX\n");
                Console.WriteLine("(2) BX\n");
                Console.WriteLine("(3) CX\n");
                Console.WriteLine("(4) DX\n");
                Console.WriteLine("(5) Reset all registries\n");
                Console.WriteLine("\n() Any other key to return\n");

                bool isNumber = int.TryParse(Console.ReadLine(), out int ChoosenOption);

                if (isNumber)
                {
                    switch (ChoosenOption)
                    {

                        case 1:
                            ZeroRegistryValues(ref Registries.AxValue, ref Registries.AxToAddAndSub, ref Registries.AxValueStringOnly);
                            Success("AX Registry has been");
                            break;

                        case 2:
                            ZeroRegistryValues(ref Registries.BxValue, ref Registries.BxToAddAndSub, ref Registries.BxValueStringOnly);
                            Success("BX Registry has been");
                            break;

                        case 3:
                            ZeroRegistryValues(ref Registries.CxValue, ref Registries.CxToAddAndSub, ref Registries.CxValueStringOnly);
                            Success("CX Registry has been");
                            break;

                        case 4:
                            ZeroRegistryValues(ref Registries.DxValue, ref Registries.DxToAddAndSub, ref Registries.DxValueStringOnly);
                            Success("DX Registry has been");
                            break;

                        case 5:
                            ZeroRegistryValues(ref Registries.AxValue, ref Registries.AxToAddAndSub, ref Registries.AxValueStringOnly);
                            ZeroRegistryValues(ref Registries.BxValue, ref Registries.BxToAddAndSub, ref Registries.BxValueStringOnly);
                            ZeroRegistryValues(ref Registries.CxValue, ref Registries.CxToAddAndSub, ref Registries.CxValueStringOnly);
                            ZeroRegistryValues(ref Registries.DxValue, ref Registries.DxToAddAndSub, ref Registries.DxValueStringOnly);
                            Success("All Registries have been");
                            break;
                    }
                }
                else
                {
                    break;
                }

                break;
            }
        }

        //Resets Values

        public static void ZeroRegistryValues(ref string Registry, ref int IntAuxiliaryValue, ref string StringAuxiliaryValue)
        {
            Registry = 0.ToString();
            IntAuxiliaryValue = 0;
            StringAuxiliaryValue = 0.ToString();
        }

        //Displaying Messages

        public static void Success(string RegistryName)
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Reseting is about to begin");
            Console.ResetColor();

            PleaseWait.Wait();

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"\nSuccess! {RegistryName} successfully reseted! Press Any Key to Return.\n");
            Console.ResetColor();
            Console.ReadLine();
        }
    }
}
