using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microprocessor_Emulator
{
    public class Registries
    {
        //Displayed dashboard values
        public static string? AxValue = 0.ToString();
        public static string? BxValue = 0.ToString();
        public static string? DxValue = 0.ToString();
        public static string? CxValue = 0.ToString();

        //Auxiliary variables to perform calculations based on conversions and numbers.
        //Helps a lot in recognizing value as a number or string. 
        //When registry stores number, the number is assigned here and ValueStringOnly of current register is assigned to 0.
        public static int AxToAddAndSub = 0;
        public static int BxToAddAndSub = 0;
        public static int CxToAddAndSub = 0;
        public static int DxToAddAndSub = 0;

        //Auxiliary variables to store strings and perform calculations based on strings.
        //Helps a lot in recognizing value as a string or string stored as bits of informations.
        //When registry stores string, the string is assigned to below ValueStringOnly variable and its ToAddAndSub value is equal 0.
        //When registry stores string-stored-as-bits-of-Information, the value of ValueStringOnly variable is equal O. Either it's ToAddAndSub value.
        public static string? AxValueStringOnly = 0.ToString();
        public static string? BxValueStringOnly = 0.ToString();
        public static string? DxValueStringOnly = 0.ToString();
        public static string? CxValueStringOnly = 0.ToString();
    }
}
