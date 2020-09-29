using System;
using System.Text;

namespace Roman
{
    public static class ExtensionMethods
    {
        public static string ToRoman(this int i)
        {
            int thousands = i / 1000;
            int fivehundreds = (i - thousands * 1000) / 500;
            int hundreds = (i - thousands * 1000 - fivehundreds * 500) / 100;
            int fiftees = (i - thousands * 1000 - fivehundreds * 500 - hundreds * 100) / 50;
            int tens = (i - thousands * 1000 - fivehundreds * 500 - hundreds * 100 - fiftees * 50) / 10;
            int fives = (i - thousands * 1000 - fivehundreds * 500 - hundreds * 100 - fiftees * 50 - tens * 10) / 5;
            int ones = (i - thousands * 1000 - fivehundreds * 500 - hundreds * 100 - fiftees * 50 - tens * 10 - fives * 5);

            StringBuilder romanNumber = new StringBuilder();

            romanNumber.Append('M', thousands);
            AppendOrder(fivehundreds, 'D', hundreds, 'C', 'M', romanNumber);
            AppendOrder(fiftees, 'L', tens, 'X', 'C', romanNumber);
            AppendOrder(fives, 'V', ones, 'I', 'X', romanNumber);

            return romanNumber.ToString();
        }

        private static void AppendOrder(int fives, char fiveSymbol, int ones, char oneSymbol, char tenSymbol, StringBuilder romanNumber)
        {
            romanNumber.Append(fiveSymbol, fives);

            if (ones == 4 && fives == 1)
            {
                romanNumber.Remove(romanNumber.Length - 1, 1);
                romanNumber.Append(string.Concat(oneSymbol, tenSymbol));
            }
            else if (ones == 4)
            {
                romanNumber.Append(string.Concat(oneSymbol, fiveSymbol));
            }
            else
            {
                romanNumber.Append(oneSymbol, ones);
            }
        }
    }
}
