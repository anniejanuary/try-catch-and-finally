using System;

namespace TryCatchAndFinally
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number: ");
            string userInput = Console.ReadLine();

            try
            {
                int userInputToInt = int.Parse(userInput);
            }
            catch (Exception)
            {
                Console.WriteLine("Please only enter numbers");
            }

            finally
            {
                Console.WriteLine("This closes the internet connection or sth?");
            }
            Console.ReadLine();
        }
    }
}
