namespace Temperature_Converter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Select Temperature.");
                Console.WriteLine("1 for Celsius:");
                Console.WriteLine("2 for Fahrenheit:");
                Console.WriteLine("3 to Exit:");

                int choice;
                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            CelsiusToFarenheit();
                            break;

                        case 2:
                            FarenheitToCelcius();
                            break;

                        case 3:
                            exit = true;
                            break;

                        default:
                            Console.WriteLine("Invalid...");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid...");
                }
            }
        }

        static void CelsiusToFarenheit()
        {
            Console.WriteLine("Enter Temperature: ");
            decimal temp;

            if (decimal.TryParse(Console.ReadLine(), out temp) && temp > 0)
            {
                decimal FarenheitResult = temp * 9 / 5 + 32;
                Console.WriteLine($"You enter {temp} C converted to {FarenheitResult} F");
            }
            else
            {
                Console.WriteLine("Invalid...");
            }
        }
        static void FarenheitToCelcius()
        {
            Console.WriteLine("Enter Temeperature:");
            decimal temp;

            if (decimal.TryParse(Console.ReadLine(), out temp) && temp > 0)
            {
                decimal CelciusResult = (temp - 32) * 5 / 9;
                Console.WriteLine($"You enter {temp} F converted to {CelciusResult} C");
            }
            else
            {
                Console.WriteLine("Invalid..");
            }

        }
    }
}
