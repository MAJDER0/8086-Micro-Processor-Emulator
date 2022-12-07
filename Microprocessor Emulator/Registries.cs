using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microprocessor_Emulator
{
    public static class Registries
    {
        //displayed final values
        public static string? AxValue = 0.ToString();
        public static string? BxValue = 0.ToString();
        public static string? DxValue = 0.ToString();
        public static string? CxValue = 0.ToString();

        //auxiliary to perform calculations based on conversions and numbers
        public static int AxToAddAndSub=0;
        public static int BxToAddAndSub=0;
        public static int CxToAddAndSub=0;
        public static int DxToAddAndSub=0;

        //auxiliary to store strings and perform calculations based on strings
        public static string? AxValueStringOnly = 0.ToString();
        public static string? BxValueStringOnly = 0.ToString();
        public static string? DxValueStringOnly = 0.ToString();
        public static string? CxValueStringOnly = 0.ToString();
    }
}
