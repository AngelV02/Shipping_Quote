using System;

namespace Shipping_Quote
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print the welcome message
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // Prompt for the package weight
            Console.WriteLine("Please enter the package weight:");
            string weightInput = Console.ReadLine();
            double weight = Convert.ToDouble(weightInput);

            // Check if the weight exceeds the limit
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                return; // End the program
            }

            // Prompt for package dimensions
            Console.WriteLine("Please enter the package width:");
            string widthInput = Console.ReadLine();
            double width = Convert.ToDouble(widthInput);

            Console.WriteLine("Please enter the package height:");
            string heightInput = Console.ReadLine();
            double height = Convert.ToDouble(heightInput);

            Console.WriteLine("Please enter the package length:");
            string lengthInput = Console.ReadLine();
            double length = Convert.ToDouble(lengthInput);

            // Calculate the volume of the package
            double volume = width * height * length;

            // Check if the dimensions total exceeds the limit
            double dimensionsTotal = width + height + length;
            if (dimensionsTotal > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                return; // End the program
            }

            // Calculate the quote
            double quote = (volume * weight) / 100;

            // Display the quote
            Console.WriteLine("Your estimated total for shipping this package is: $" + quote.ToString("F2"));
            Console.WriteLine("Thank you!");
        }
    }
}
