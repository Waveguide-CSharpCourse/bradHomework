using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Program
    {
        struct Transaction
        {
            public string bankName;
            public string acctHolder;
            public int acctNumber;
            public string fedRefNum;
            public decimal amount;
            public string transDate;
        };

        static void Main()
        {

            string path = @"C:\data\ass3\";
            string[] files = Directory.GetFiles(path);
            List<Transaction> transactions = new List<Transaction>();
            //List<string> parsedData = new List<string>();

            foreach (string file in files)
            {
                if (file.StartsWith(path+"S"))
                {
                    try
                    {

                    }
                    catch
                    {

                    }

                }

                else if (file.StartsWith(path+"W"))
                {
                    try
                    {
                        using (StreamReader readFile = new StreamReader(file))
                        {
                            string line;
                            string[] row;
                            Console.WriteLine("processing {0}", file);

                            while ((line = readFile.ReadLine()) != null)
                            {
                                row = line.Split(',');
                                transactions.Add(new Transaction()
                                {
                                    bankName = row[0],
                                    acctHolder = row[1],
                                    acctNumber = Convert.ToInt32(row[2]),
                                    fedRefNum = row[4],
                                    amount = Convert.ToDecimal(row[6]),
                                    transDate = row[7]
                                });
                                Console.WriteLine(row[0]);
                            }
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }

                }   

            }

            
            foreach (Transaction trans in transactions)
            {
                Console.WriteLine(trans.acctHolder);
            }
            Console.ReadKey();
            

        }
    }
}