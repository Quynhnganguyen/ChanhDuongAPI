using System;

namespace ChanhDuongApiConsumer
{
    class Program
    {
        private static string toBeContinued;

        static void Main()
        {
            Console.WriteLine("Welcome to ChanhDuongAPI consumer!!!");
            toBeContinued = "Y";
            while (toBeContinued.ToLower() == "y")
            {
                Console.WriteLine();
                Console.WriteLine("Choose Service for consuming:");
                Console.WriteLine("Typing 1: Fibonacci Service.");
                Console.WriteLine("Typing 2: XmlToJson Service.");
                string serviceChoice = Console.ReadLine();

                switch (serviceChoice)
                {
                    case "1":
                        FibonacciConsumer();
                        break;
                    case "2":
                        XmlToJsonConsumer();
                        break;
                    case "exit":
                        toBeContinued = "exit";
                        break;
                    default:
                        Console.WriteLine("Please choose 1 or 2!");
                        continue;
                };
                if (toBeContinued == "exit")
                    continue;
                Console.WriteLine();
                Console.WriteLine("Do you want to consume an other Service? (Y/N) ");
                toBeContinued = Console.ReadLine();
            }
        }

        static void FibonacciConsumer()
        {
            Console.WriteLine();
            Console.WriteLine("----- CONSUMING FIBONACCI SERVICE -----");
            Console.WriteLine("N = ");
            string inputString = Console.ReadLine();
            if (inputString.ToLower() == "exit")
            {
                toBeContinued = "exit";
                return;
            }
            try
            {
                int n = Int32.Parse(inputString);
                Console.WriteLine();
                Console.WriteLine("Waitting for Fibonacci Service ...");

                try
                {
                    var soapClient = new ChanhDuongAPI.ChuaNgotServiceSoapClient();
                    var response = soapClient.Fibonacci(n);
                    Console.WriteLine("Fibonacci of " + n + ": " + response);
                }
                catch (Exception err)
                {
                    Console.WriteLine("[Error] " + err.Message + " | " + err.StackTrace);
                }
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static void XmlToJsonConsumer()
        {
            Console.WriteLine();
            Console.WriteLine("----- CONSUMING XMLTOJSON SERVICE -----");
            Console.WriteLine("XML = ");
            string inputString = Console.ReadLine();
            if (inputString.ToLower() == "exit")
            {
                toBeContinued = "exit";
                return;
            }
            string xml = inputString;
            Console.WriteLine();
            Console.WriteLine("Waitting for XmlToJson Service ...");

            try
            {
                var soapClient = new ChanhDuongAPI.ChuaNgotServiceSoapClient();
                var response = soapClient.XmlToJson(xml);
                Console.WriteLine("Json of " + xml + " :");
                Console.WriteLine(response);
            }
            catch (Exception err)
            {
                Console.WriteLine("[Error] " + err.Message + " | " + err.StackTrace);
            }
        }
    }
}
