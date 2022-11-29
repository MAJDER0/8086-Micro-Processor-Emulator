using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microprocessor_Emulator
{
    public static class Registries
    {
        public static int AxValue { get; set; }
        public static int BxValue { get; set; }
        public static int DxValue { get; set; }
        public static int CxValue { get; set; }

        public static string AxValueStr { get; set; }
        public static string BxValueStr { get; set; }
        public static string DxValueStr { get; set; }
        public static string CxValueStr { get; set; }

    }
}
