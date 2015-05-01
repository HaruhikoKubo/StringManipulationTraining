using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "This is a book";
            var answer = InverseText(input);
            var anser2 = InverseText2(input);

        }

        static String InverseText(String inputString)
        {
            String outputString = string.Empty;
            for (int i=inputString.Length-1; i>=0; i--)
            {
                outputString += inputString[i];
            }
            return outputString;
        }

        static String InverseText2(String inputString)
        {
            String outputString = string.Empty;
            char delimiter = ' ';
            string[] inputAry = inputString.Split(delimiter);
            List<string> tempAry= new List<string>();
            for (int i=inputAry.Length-1; i>=0 ; i--)
            {
                tempAry.Add(inputAry[i]);
            }
            if (tempAry.Count != inputAry.Length)
            {
                //throw Exception
            }
            for (int i=0;i<=tempAry.Count -2; i++)
            {
                outputString += tempAry[i] + " ";
            }
            return outputString + tempAry[tempAry.Count-1];

        }

    }
}
