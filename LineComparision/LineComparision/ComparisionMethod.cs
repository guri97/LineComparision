using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparision
{
    internal class ComparisionMethod
    {
        public static int x1, x2, y1, y2;

        public void CompareLines1()
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

                FindingLength1 prg = new FindingLength1();
                prg.LineLength(x1, y1, x2, y2, i);
            }
            CheckEquality1 prg1 = new CheckEquality1();
            prg1.ComputeEquals1();
            Console.ReadLine();
        }
    }
    public class FindingLength1
    {
        public void LineLength(int x1, int y1, int x2, int y2, int i)
        {
            double sqrt = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            string val = Convert.ToString(Math.Round(sqrt, 2));
            Console.WriteLine("Length of Line is:{0}", val);
            IntializeArray1.Data1(val, i);


        }
    }
    public class CheckEquality1
    {
        public void ComputeEquals1()
        {
            //string str1 = IntializeArray1.value[0];
            //int var1 = Convert.ToInt32(str1);
            //string str2 = IntializeArray1.value[1];
            //int var2 = Convert.ToInt32(str2);
            //Console.WriteLine(string.Compare(str1, str2));
            if (IntializeArray1.value[0].Equals(IntializeArray1.value[1]) == true)

            {
                Console.WriteLine("Both line are same");
            }
            else
            {
                Console.WriteLine("Both line is different");
                string comparing = ((IntializeArray1.value[0]).CompareTo(IntializeArray1.value[1]) > 0) ? "line 1 is greater than lin2" : "line 1 is less than lin2";
                Console.WriteLine(comparing);

            }


        }
    }


    public static class IntializeArray1
    {

        public static string[] value = new string[2];
        public static void Data1(string val, int index)
        {
            value[index] = val;

        }
    }
}
