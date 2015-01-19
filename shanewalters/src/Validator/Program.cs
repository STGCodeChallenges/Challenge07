using Support;
using System;
using System.Linq;

namespace ConsoleApp1
{
    /*****************************************************************************
     * Limitation: Only works with ISBN-10 numbers. ISBN-13 has not been tested. *
     *****************************************************************************/
    public class Program
    {
        public void Main(string[] args)
        {
            Console.Write("Please enter an ISBN to verify: ");
            var input = Console.ReadLine();
            Console.WriteLine("Is Valid: {0}", Isbn10API.IsValid(input));
        }
    }
}
