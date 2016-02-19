using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {
            // create a string variable with name in it}
            string name = "Brad";
            string data1, data2, data3;

            /* Print out my name */
            Console.WriteLine("{0} doesn't know what he's doing", name);

            // Enter variables
            Console.Write("data1: ");
            data1 = Console.ReadLine();
            Console.Write("data2: ");
            data2 = Console.ReadLine();
            Console.Write("data3: ");
            data3 = Console.ReadLine();

            /// print out the variables
            Console.WriteLine("data entered: {0}, {1}, {2}", data1, data2, data3);

            // Enter more data to do math functions
            int[] dataArray = new int[6];
            Console.WriteLine("Enter 6 more integers: ");
            int counter = 0;
            for (int i = 0; i < 6; i++)
            {
                counter++;
                Console.WriteLine("Enter value {0}:", counter);
                try
                {
                    dataArray[i] = int.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Bad Monkey.  No donut. ", ex.Message);
                }
            }

            // Calculate sum, average, max value, min value 

            // sum, min and max values 
            int arraySum = 0;
            int arrayMin = int.MaxValue;
            int arrayMax = 0;
            for (int i = 0; i < dataArray.Length; i++)
            {
                arraySum = arraySum + dataArray[i];
                if (dataArray[i] > arrayMax) arrayMax = dataArray[i];
                if (dataArray[i] < arrayMin) arrayMin = dataArray[i];
            }

            //orderby
            IEnumerable<int> sortedArray =
            from k in dataArray
            orderby k
            select k;

            // average


            // print out answers
            Console.WriteLine("sum = {0}", arraySum);
            Console.WriteLine("min = {0}", arrayMin);
            Console.WriteLine("max = {0}", arrayMax);
            Console.WriteLine("NEW ORDER:");
            foreach (int i in sortedArray)
            {
                Console.Write(i);
            }

            Console.ReadKey();
        }

    }
}
