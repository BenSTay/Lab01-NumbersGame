using System;

namespace NumberGame
{
    class Program
    {
        static void StartSequence()
        {
            //Prompt user for input
            
            //Convert user input to int

            //Create new int array that is the size the user inputted

            //Call populate using the array

            //Get the sum with the GetSum method using the populated array

            //Get the product with the GetProduct method using the populated array and the sum

            //Get the quotient using the GetQuotient method using the product

            //Display the results to the console
        }

        static int[] Populate(int[] array)
        {
            //Iterate through the array, prompting the user for input each time

            //Convert user input to an integer (store the response into a string first)

            //Add the number to the array

            //Return the populated array
            return array;
        }

        static int GetSum(int[] array)
        {
            //declare an int variable named sum

            //iterate through the array, adding each number to the sum

            //if the sum is less than 20, throw an exception

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
            } catch (Exception ex)
            {
                Console.WriteLine("Oops! Something went wrong!");
                Console.WriteLine(ex.Message);
            } finally
            {
                Console.WriteLine("Thank you for playing!");
            }
        }
    }
}
