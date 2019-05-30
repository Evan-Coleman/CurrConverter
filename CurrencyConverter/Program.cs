using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp10
{
    class Program
    {
        public static void Main()
        {
            string line = "", fromCurr = "", toCurr = "";
            decimal amount;

            // @NOTE: Here you can change between live API call and a mocked repo.
            CurrConverter converter = new CurrConverter(new RatesRepo());
            //CurrConverter converter = new CurrConverter(new RatesRepoMock());

            Console.WriteLine("Hello, This is an application to convert currencies!");
            Console.WriteLine("Please enter your selection in the following format: \"amount fromCurr toCurr\"");
            Console.WriteLine("EX: 20 USD MXN");
            Console.WriteLine("Type exit to quit!");
            while (true)
            {
                Console.Write("Enter your conversion here: ");
                line = Console.ReadLine();
                if (line == "exit")
                {
                    Console.WriteLine("Thank you, exiting now");
                    return;
                }
                else
                {
                    amount = Convert.ToDecimal(line.Split(" ")[0]);
                    fromCurr = line.Split(" ")[1];
                    toCurr = line.Split(" ")[2];
                    decimal convertedAmount;
                    try
                    {
                        convertedAmount = converter.Convert(amount, fromCurr, toCurr);
                        Console.WriteLine("{0} {1} is {2:C2} in {3}", amount, fromCurr, convertedAmount, toCurr);
                    } catch
                    {
                        Console.WriteLine("There was a problem Getting a result, check that your input is valid and try again.");
                    }                    
                }
            }
        }
    }
}
