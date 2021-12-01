using System;
using System.Text;

namespace RgbConverter
{
    public static class Rgb
    {
        /// <summary>
        /// Gets hexadecimal representation source RGB decimal values.
        /// </summary>
        /// <param name="red">The valid decimal value for RGB is in the range 0-255.</param>
        /// <param name="green">The valid decimal value for RGB is in the range 0-255.</param>
        /// <param name="blue">The valid decimal value for RGB is in the range 0-255.</param>
        /// <returns>Returns hexadecimal representation source RGB decimal values.</returns>
        public static string GetHexRepresentation(int red, int green, int blue)
        {
            return DecimalToHex(red) + DecimalToHex(green) + DecimalToHex(blue);
        }

        private static string DecimalToHex(int number)
        {
            if (number < 0)
            {
                return "00";
            }

            if (number > 255)
            {
                return "FF";
            }

            StringBuilder res = new StringBuilder();

            while (res.Length < 2)
            {
                switch (number % 16)
                {
                    case 0:
                        res.Insert(0, "0");
                        break;
                    case 1:
                        res.Insert(0, "1");
                        break;
                    case 2:
                        res.Insert(0, "2");
                        break;
                    case 3:
                        res.Insert(0, "3");
                        break;
                    case 4:
                        res.Insert(0, "4");
                        break;
                    case 5:
                        res.Insert(0, "5");
                        break;
                    case 6:
                        res.Insert(0, "6");
                        break;
                    case 7:
                        res.Insert(0, "7");
                        break;
                    case 8:
                        res.Insert(0, "8");
                        break;
                    case 9:
                        res.Insert(0, "9");
                        break;
                    case 10:
                        res.Insert(0, "A");
                        break;
                    case 11:
                        res.Insert(0, "B");
                        break;
                    case 12:
                        res.Insert(0, "C");
                        break;
                    case 13:
                        res.Insert(0, "D");
                        break;
                    case 14:
                        res.Insert(0, "E");
                        break;
                    case 15:
                        res.Insert(0, "F");
                        break;
                }

                number /= 16;
            }

            return res.ToString();
        }
    }
}
