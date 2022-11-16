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
            int AxValue=0,BxValue=0,DxValue=0;

            while (true) { 

                int TriggerAction;
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("Select one: \n");
                Console.ResetColor();

                Console.WriteLine("(1) Show current registries value\n");
                Console.WriteLine("(2) Enter value to choosen registry\n");
                Console.WriteLine("() Press any other key to return menu\n");

                int.TryParse(Console.ReadLine(),out TriggerAction);
                Console.WriteLine();

                if(TriggerAction==0)
                { 
                    break;
                
                }

                if(TriggerAction==1)
                { 
                    Console.WriteLine($"AX Value: {AxValue}");
                    Console.WriteLine($"BX Value: {BxValue}");
                    Console.WriteLine($"DX Value: {DxValue}");
                    Console.WriteLine();
                    
                    Console.WriteLine("Press any key to come back\n");
                    Console.ReadLine();
                    continue;

                }

                
                if (TriggerAction == 2) { 
                    
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("Select registry you want to enter the value: \n");
                    Console.ResetColor();
                    Console.WriteLine("(1) AX");
                    Console.WriteLine("(2) BX");
                    Console.WriteLine("(3) DX\n");


                    while(true) {

                        int ChoosenRegistry;
                        int.TryParse(Console.ReadLine(), out ChoosenRegistry);
                        Console.WriteLine();

                        

                                if (ChoosenRegistry == 1)
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                    Console.WriteLine("You have choosen AX Registry, please enter value now: \n");
                                    Console.ResetColor();

                                    int AxResult;
                                    int.TryParse(Console.ReadLine(), out AxResult);
                                    Console.WriteLine();                            

                                     AxValue = AxResult;
                             
                                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                    Console.WriteLine("Select registry you want to move that value in: \n");
                                    Console.ResetColor();
                                    Console.WriteLine("(1) BX");
                                    Console.WriteLine("(2) DX\n");
                                
                                        while (true) { 

                                             int SelectedRegistryToMove;
                                             int.TryParse(Console.ReadLine(), out SelectedRegistryToMove);
                                             Console.WriteLine();

                                                    if (SelectedRegistryToMove == 1)

                                                    {
                                                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                                        Console.WriteLine("You have choosen BX registry, moving process is about to begin: \n");
                                                        Console.ResetColor();

                                                        BxValue = AxValue;
                                                        AxValue=0;

                                                        Console.WriteLine("Please wait. . .");
                                                        System.Threading.Thread.Sleep(1000);
                                                        Console.WriteLine("Please wait. . .");
                                                        System.Threading.Thread.Sleep(1000);
                                                        Console.WriteLine("Please wait. . .");
                                                        System.Threading.Thread.Sleep(1000);

                                                        Console.WriteLine();
                                                        
                                                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                                                        Console.WriteLine($"BX value now: {BxValue}");
                                                        Console.ResetColor();

                                                        Console.WriteLine("Press any key to come back");
                                                        Console.ReadLine();
                                                        break;

                                                    }

                                                    if (SelectedRegistryToMove == 2)
                                                    {
                                                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                                        Console.WriteLine("You have choosen DX registry, moving process is about to begin: \n");
                                                        Console.ResetColor();

                                                        DxValue = AxValue;
                                                        AxValue=0; 


                                                        Console.WriteLine("Please wait. . .");
                                                        System.Threading.Thread.Sleep(1000);
                                                        Console.WriteLine("Please wait. . .");
                                                        System.Threading.Thread.Sleep(1000);
                                                        Console.WriteLine("Please wait. . .");
                                                        System.Threading.Thread.Sleep(1000);

                                                        Console.WriteLine();
                                                        
                                                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                                                        Console.WriteLine($"DX value now: {DxValue}");
                                                        Console.ResetColor();
                                            
                                                        Console.WriteLine("Press any key to come back");
                                                        Console.ReadLine();
                                                        break;
                                                    }

                                              else 
                                              {
                                                  Console.ForegroundColor = ConsoleColor.DarkRed;
                                                  Console.WriteLine("Please choose correct registry to copy");
                                                  Console.ResetColor();
                                                  continue;
                                              }

                                                    break;
                                        }
                                    break;
                                }
 

                            if (ChoosenRegistry == 2)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                Console.WriteLine("You have choosen BX Registry, please enter value now: \n");
                                Console.ResetColor();

                                int BxResult;
                                int.TryParse(Console.ReadLine(), out BxResult);
                                Console.WriteLine();

                                BxValue=BxResult ;
                                
                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                Console.WriteLine("Select registry you want to move that value in: \n");
                                Console.ResetColor();
                                Console.WriteLine("(1) AX");
                                Console.WriteLine("(2) DX");

                                Console.WriteLine();
                                while (true) { 

                                    int SelectedRegistryToMove;
                                    int.TryParse(Console.ReadLine(), out SelectedRegistryToMove);
                                    Console.WriteLine();

                                                    if (SelectedRegistryToMove == 1)

                                                    {
                                                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                                        Console.WriteLine("You have choosen AX registry, moving process is about to begin: \n");
                                                        Console.ResetColor();

                                                         AxValue = BxValue;
                                                         BxValue=0;

                                                        Console.WriteLine("Please wait. . .");
                                                        System.Threading.Thread.Sleep(1000);
                                                        Console.WriteLine("Please wait. . .");
                                                        System.Threading.Thread.Sleep(1000);
                                                        Console.WriteLine("Please wait. . .");
                                                        System.Threading.Thread.Sleep(1000);

                                                        Console.WriteLine();
                                                        
                                                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                                                        Console.WriteLine($"AX value now: {AxValue}");
                                                        Console.ResetColor();

                                                        Console.WriteLine("Press any key to come back");
                                                        Console.ReadKey();
                                                        break;

                                                    }

                                                    if (SelectedRegistryToMove == 2)

                                                    {
                                                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                                        Console.WriteLine("You have choosen DX registry, moving process is about to begin: \n");
                                                        Console.ResetColor();

                                                         DxValue = BxValue;
                                                         BxValue=0;

                                                        Console.WriteLine("Please wait. . .");
                                                        System.Threading.Thread.Sleep(1000);
                                                        Console.WriteLine("Please wait. . .");
                                                        System.Threading.Thread.Sleep(1000);
                                                        Console.WriteLine("Please wait. . .");
                                                        System.Threading.Thread.Sleep(1000);

                                                        Console.WriteLine();

                                                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                                                        Console.WriteLine($"DX value now: {DxValue}");
                                                        Console.ResetColor();

                                                        Console.WriteLine("Press any key to come back");
                                                        Console.ReadKey();
                                                        break;

                                                    }

                                                  else 
                                                  {
                                                      Console.ForegroundColor = ConsoleColor.DarkRed;
                                                      Console.WriteLine("Please choose correct registry to copy");
                                                      Console.ResetColor();
                                                      continue;
                                                  }
                                        break;
                                }

                                break;
                            }


                        

                        if (ChoosenRegistry == 3)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            Console.WriteLine("You have choosen DX Registry, please enter value now: \n");
                            Console.ResetColor();

                            int DxResult;
                            int.TryParse(Console.ReadLine(), out DxResult);

                             DxValue = DxResult;

                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            Console.WriteLine("Select registry you want to move that value in: \n");
                            Console.ResetColor();
                            Console.WriteLine("(1) AX");
                            Console.WriteLine("(2) BX\n");

                            while (true) { 
                                int SelectedRegistryToMove;
                                int.TryParse(Console.ReadLine(), out SelectedRegistryToMove);

                                                if (SelectedRegistryToMove == 1)

                                                {
                                                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                                    Console.WriteLine("You have choosen AX registry, moving process is about to begin: \n");
                                                    Console.ResetColor();

                                                    AxValue = DxValue;
                                                    DxValue=0;

                                                    Console.WriteLine("Please wait. . .");
                                                    System.Threading.Thread.Sleep(1000);
                                                    Console.WriteLine("Please wait. . .");
                                                    System.Threading.Thread.Sleep(1000);
                                                    Console.WriteLine("Please wait. . .");
                                                    System.Threading.Thread.Sleep(1000);

                                                    Console.WriteLine();

                                                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                                                    Console.WriteLine($"AX value now: {AxValue}");
                                                    Console.ResetColor();

                                                    Console.WriteLine("Press any key to come back");
                                                    Console.ReadKey();
                                                    break;

                                                }

                                                if (SelectedRegistryToMove == 2)

                                                {
                                                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                                    Console.WriteLine("You have choosen BX registry, moving process is about to begin: \n");
                                                    Console.ResetColor();

                                                    BxValue = DxValue;
                                                    DxValue = 0;

                                                    Console.WriteLine("Please wait. . .");
                                                    System.Threading.Thread.Sleep(1000);
                                                    Console.WriteLine("Please wait. . .");
                                                    System.Threading.Thread.Sleep(1000);
                                                    Console.WriteLine("Please wait. . .");
                                                    System.Threading.Thread.Sleep(1000);

                                                    Console.WriteLine();

                                                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                                                    Console.WriteLine($"BX value now: {BxValue}");
                                                    Console.ResetColor();

                                                    Console.WriteLine("Press any key to come back");
                                                    Console.ReadKey();
                                                    break;

                                                }

                                                else 
                                                {
                                                  Console.ForegroundColor = ConsoleColor.DarkRed;
                                                  Console.WriteLine("Please choose correct registry to copy");
                                                  Console.ResetColor();
                                                  continue;
                                                }

                                     break;

                            }

                             break;

                        }

                        else
                        { 
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Choose correctly");
                            Console.ResetColor();
                            continue;
                        }
                        
                    }
                    continue;
                }

                    break;     

            }
        }

    }


}
