using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparision
{
    internal class ComparingLine
    {
        public static int x1, x2, y1, y2;

        public void CompareLines()
        {

            for (int i = 0; i < 2; i++)
            {
                Console.Write("Enter value for Coordinate x1 : ");
                x1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter value for Coordinate y1 : ");
                y1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter value for Coordinate x2 : ");
                x2 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter value for Coordinate y2 : ");
                y2 = Convert.ToInt32(Console.ReadLine());

                FindingLength prg = new FindingLength();
                prg.LineLength(x1, y1, x2, y2, i);
            }
            CheckEquality prg1 = new CheckEquality();
            prg1.ComputeEquals();
            Console.ReadLine();
        }
    }
    public class FindingLength
    {
        public void LineLength(int x1, int y1, int x2, int y2, int i)
        {
            double sqrt = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            string val = Convert.ToString(Math.Round(sqrt, 2));
            Console.WriteLine("Length of Line is:{0}", val);
            IntializeArray.Data(val, i);
        }
    }
    public class CheckEquality
    {
        public void ComputeEquals()
        {
            if (IntializeArray.values[0].Equals(IntializeArray.values[1]) == true)

            {
                Console.WriteLine("Both line are same");
            }
            else
            {
                Console.WriteLine("Both line is different");

            }

        }
    }


    public static class IntializeArray
    {

        public static string[] values = new string[2];
        public static void Data(string val, int index)
        {
            values[index] = val;
        }
    }
}
