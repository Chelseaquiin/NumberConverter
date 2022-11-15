using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersInWords
{
    public class ConvertToWords
    {
        public int Number { get; set; }

        public ConvertToWords(int number)
        {
            Number = number;
        }

        public string Conversion(int number)
        {
            string[] units = {"", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven",
            "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen","Eighteen", "Nineteen"};

            string[] tens = { "", "", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };

            if(number < 0)
            {
                return "minus" + Conversion(-number);
            }
            else if(number < 20)
            {
                return units[number];
            }
            else if(number < 100)
            {
                return tens[number / 10] + units[number % 10];
            }
            else if(number < 1000)
            {
                return units[number / 100] + " Hundred " + Conversion(number % 100);
            }

            else if (number < 20000)
            {
                return units[number / 1000] + " Thousand " + Conversion(number % 1000);
            }
            else if (number < 100000)
            {
                return Conversion(number / 1000) + " Thousand " + Conversion(number % 1000);
            }

            return Conversion(number / 1000) + " Thousand" + Conversion(number % 1000);
        }
    }
}
