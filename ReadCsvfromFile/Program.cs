using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadCsvfromFile
{
    class Program
    {
        static string theLine;
        static int[] theList;
        static int LineNumber = 1;
        static int theSum;
        static StreamReader file = new StreamReader("C: /Users/amand/OneDrive/Documents/visual studio 2015/Projects/ReadCsvfromFile/TextFiletobeRead.txt");
        static void Main(string[] args)
        {
            while ((theLine = file.ReadLine()) != null)
            {
                Add(theLine);
            }
            file.Close();

            Console.ReadLine();
        }

        private static void Add(string theLine)
        {
            if (theLine.Contains(";"))
            {
                theList = theLine.Split(';').Select(int.Parse).ToArray();
            }
            else if (theLine.Contains(","))
            {
                theList = theLine.Split(',').Select(int.Parse).ToArray();
            }
            else
            {
                throw new ArgumentException();
            }

            theSum = theList.Sum();

            Console.WriteLine("The sum of the numbers entered at line : " + LineNumber.ToString() + " is : " + theSum);
            LineNumber++;
        }
    }
}
