using System;

namespace NumberGame
{
    class Program
    {
        static void StartSequence()
        {
            int length, product;
            decimal quotient;
            int[] array;

            //Prompt user for input
            Console.WriteLine("Welcome to NumberGame! Let's crunch some numbers!");
            Console.Write("Please enter a number greater than zero: ");
            string input = Console.ReadLine();

            //Convert user input to int
            try
            {
                length = Convert.ToInt32(input);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Continuing with default value 5");
                length = 5;
            }

            //Create new int array that is the size the user inputted
            try
            {
                array = new int[length];
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Continuing with default value 5");
                array = new int[5];
            }


            //Call populate using the array
            try
            {
                array = Populate(array);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Populating array with random values...");
                Random rng = new Random();
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == 0) array[i] = rng.Next(20, 100);
                }
            }

            //Get the sum with the GetSum method using the populated array
            int sum = GetSum(array);


            //Get the product with the GetProduct method using the populated array and the sum
            try
            {
                product = GetProduct(array, sum);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Using first array element for product...");
                product = sum * array[0];
            }


            //Get the quotient using the GetQuotient method using the product
            try
            {
                quotient = GetQuotient(product);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Using first array element as divisor...");
                quotient = Decimal.Divide(product, array[0]);
            }

            //Display the results to the console
            Console.WriteLine($"Your array size: {length}");
            Console.WriteLine($"Your array: {string.Join(", ", array)}");
            Console.WriteLine($"The sum of these numbers is {sum}");
            Console.WriteLine($"{sum} * {product / sum} = {product}");
            if (quotient != 0M) Console.WriteLine($"{product} / {product / quotient} = {quotient}");
            else Console.WriteLine($"{product} / 0 = infinity");

        }

        static int[] Populate(int[] array)
        {
            string input;

            //Iterate through the array, prompting the user for input each time
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Please enter a number ({i + 1} of {array.Length}): ");

                //Convert user input to an integer (store the response into a string first)
                input = Console.ReadLine();

                //Add the number to the array
                array[i] = Convert.ToInt32(input);
            }

            //Return the populated array
            return array;
        }

        static int GetSum(int[] array)
        {
            //declare an int variable named sum
            int sum = 0;

            //iterate through the array, adding each number to the sum
            foreach (int num in array)
            {
                sum += num;
            }

            //if the sum is less than 20, throw an exception
            if (sum < 20) throw new Exception($"Value of {sum} is too low");

            //return sum
            return sum;
        }

        static int GetProduct(int[] array, int sum)
        {
            string input;
            int index, product;

            //prompt the user for numeric input between 1 and the arrays length
            Console.Write($"Pick a number between 1 and {array.Length}: ");
            input = Console.ReadLine();
            index = Convert.ToInt32(input) - 1;

            //multiply sum by number at given index in array
            if (index < 0 || index >= array.Length) throw new IndexOutOfRangeException($"{index + 1} is not a number between 1 and {array.Length}!");
            else product = sum * array[index];

            //return product
            return product;
        }

        static decimal GetQuotient(int product)
        {
            string input;
            int divisor;
            decimal quotient;

            //prompt the user to enter a number to divide the product by (display the product)
            Console.Write($"Enter a number to divide {product} by: ");

            //retrieve input and convert
            input = Console.ReadLine();
            divisor = Convert.ToInt32(input);

            //divide the product by the inputted number
            try
            {
                quotient = Decimal.Divide(product, divisor);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
                quotient = 0M;
            }

            //return the quotient
            return quotient;
        }

        static void Main(string[] args)
        {
            try
            {
                StartSequence();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Oops! Something went wrong!");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Thank you for playing!");
            }
        }
    }
}
