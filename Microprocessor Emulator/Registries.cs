using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microprocessor_Emulator
{
    public static class Registries
    {
        //display
        public static string? AxValue = 0.ToString();
        public static string? BxValue = 0.ToString();
        public static string? DxValue = 0.ToString();
        public static string? CxValue = 0.ToString();

        //auxiliary
        public static int AxToAddAndSub=0;
        public static int BxToAddAndSub=0;
        public static int CxToAddAndSub=0;
        public static int DxToAddAndSub=0;
    }
}
