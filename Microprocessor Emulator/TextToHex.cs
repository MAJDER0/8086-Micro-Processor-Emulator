using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microprocessor_Emulator
{
    public class TextToHex
    {

        public static string AsciiToHex(string asciiString)
        {
            StringBuilder builder = new StringBuilder();
            foreach (char c in asciiString)
            {
                builder.Append(Convert.ToInt32(c).ToString("X"));
            }
            return builder.ToString();
        }


        public static byte[] FromHex(string hex)
        {
            hex = hex.Replace("-", "");
            byte[] raw = new byte[hex.Length / 2];
            for (int i = 0; i < raw.Length; i++)
            {
                raw[i] = Convert.ToByte(hex.Substring(i * 2, 2), 16);
            }
            return raw;
        }



    }
}
