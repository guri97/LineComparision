using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparision
{
    internal class UC1_LineLength
    {
      
        
             public void Distancecalc()
            {

                Console.WriteLine("Enter the value for x1");
                int x1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the value for y1");
                int y1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the value for x2");
                int x2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the value for y2");
                int y2 = Convert.ToInt32(Console.ReadLine());


                double var1 = Math.Pow((x2 - x1), 2);
                double var2 = Math.Pow((y2 - y1), 2);
                double Result = Math.Sqrt(var1 + var2);
                Console.WriteLine("distance between coordinates {0},{1} and {2},{3} is {4}", x1, y1, x2, y2, Result);






            }
        }
    }

