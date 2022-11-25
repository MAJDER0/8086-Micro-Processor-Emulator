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
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("What would you like to add?\n");
                Console.ResetColor();

                Console.WriteLine("(1)Add one registry value to another registry\n");
                Console.WriteLine("(2)Add value to choosen registry\n");

                int TriggerAction;
                
                int.TryParse(Console.ReadLine(), out TriggerAction);
                
                    if (TriggerAction==1)
                    { 
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine("Select registry you wanna add to another: \n");
                        Console.ResetColor();
                        Console.WriteLine("(1)AX\n");
                        Console.WriteLine("(2)BX\n");
                        Console.WriteLine("(3)CX\n");
                        Console.WriteLine("(4)DX\n");

                        int ChoosenRegistry;
                        int.TryParse(Console.ReadLine(), out ChoosenRegistry);
                        
                        if(ChoosenRegistry==1)
                        {
                            
                        }

                        if(ChoosenRegistry==2)
                        {
                    
                    
                        }


                        if(ChoosenRegistry==3)
                        {
                    
                    
                        }

                        if(ChoosenRegistry==4)
                        { 
                    
                    
                        }
                        else 
                        { 
                            
                        }
                    }

                    if (TriggerAction==2)
                    { 
                        Console.WriteLine("");
                    }

                    else
                    { 
                        
                        Console.WriteLine("");
                    }
            }
        }

    }
}
