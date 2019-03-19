using System;

namespace NumberGame
{
    class Program
    {
        static void StartSequence()
        {
            //Prompt user for input
            Console.WriteLine("Welcome to NumberGame! Let's crunch some numbers!");
            Console.Write("Please enter a number greater than zero: ");
            string input = Console.ReadLine();

            //Convert user input to int
            int length = Convert.ToInt32(input);

            //Create new int array that is the size the user inputted
            int[] array = new int[length];

            //Call populate using the array
            array = Populate(array);

            //Get the sum with the GetSum method using the populated array
            int sum = GetSum(array);

            //Get the product with the GetProduct method using the populated array and the sum
            int product = GetProduct(array, sum);

            //Get the quotient using the GetQuotient method using the product
            decimal quotient = GetQuotient(product);

            //Display the results to the console
            Console.WriteLine($"Your array size: {length}");
            Console.WriteLine(string.Join(", ", array));
            Console.WriteLine($"The sum of these numbers is {sum}");
            Console.WriteLine($"{sum} * {product / sum} = {product}");
            Console.WriteLine($"{product} / {product / quotient} = {quotient}");
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
            return array[0];
        }

        static int GetProduct(int[] array, int sum)
        {
            //prompt the user for numeric input between 1 and the arrays length

            //declare new int variable 'product'

            //multiply sum by number at given index in array

            //return product
            return sum;
        }

        static decimal GetQuotient(int product)
        {
            //prompt the user to enter a number to divide the product by (display the product)

            //retrieve input and convert

            //divide the product by the inputted number

            //return the quotient
            return (decimal)product;
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
