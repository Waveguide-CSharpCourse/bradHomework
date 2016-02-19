using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circle
{
    class Program
    {
        //test
        static decimal PI = 3.141592654m;
        static void Main(string[] args)
        {
            bool reading = true;
            decimal circleArea;
            decimal circleCircumference;

            while (reading)
            {
                Console.WriteLine("Enter Radius: (? to end)");
                string radius = Console.ReadLine();
                if (radius == "?")
                {
                    reading = false;
                    break;
                }
                decimal result;
                if (decimal.TryParse(radius, out result))
                {
                    //compute area and circumference
                    circleArea = computeCircleArea(result);
                    circleCircumference = computeCircleCircumference(result);
                    Console.WriteLine("Area = {0}", circleArea);
                    Console.WriteLine("Circumference = {0}", circleCircumference);
                }
                else
                {
                    Console.WriteLine("LAME.");
                }
            }

        }
        static decimal computeCircleArea(decimal radius)
        {
            decimal area = Program.PI * radius * radius;
            return area;
        }
        static decimal computeCircleCircumference(decimal radius)
        {
            decimal circum = 2.0m * Program.PI * radius;
            return circum;
        }
    }

}
