using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Code Challenge #7

This weeks challenge is as follows:
 
ISBN's (International Standard Book Numbers) are identifiers for books. Given the correct sequence of digits, one book can be identified out of millions of 
 others thanks to this ISBN. But when is an ISBN not just a random slurry of digits? That's for you to find out.
 
Given the following constraints of the ISBN number, you should write a function that can return True if a number is a valid ISBN and False otherwise.
 
An ISBN is a ten digit code which identifies a book. The first nine digits represent the book and the last digit is used to make sure the ISBN is correct.
 
To verify an ISBN you :-
•obtain the sum of 10 times the first digit, 9 times the second digit, 8 times the third digit... all the way till you add 1 times the last digit. 
 If the sum leaves no remainder when divided by 11 the code is a valid ISBN.
 
For example :
 
0-7475-3269-9 is Valid because 
 
(10 * 0) + (9 * 7) + (8 * 4) + (7 * 7) + (6 * 5) + (5 * 3) + (4 * 2) + (3 * 6) + (2 * 9) + (1 * 9) = 242 which can be divided by 11 and have no remainder. 
 
For the cases where the last digit has to equal to ten, the last digit is written as X. For example 156881111X.
 
For a Bonus Entry
 
Write an ISBN generator. That is, a program that will output a valid ISBN number (bonus if you output an ISBN that is already in use.
 */

namespace CodeChallenge07_IsbnValidator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string input;
            do
            {
                Console.WriteLine("\n\nEnter a 10 or 13 digit ISBN to validate (q to quit): ");
                input = Console.ReadLine();
                Console.WriteLine("Validation result: " + ValidateIsbn(input));
            } while (input != "q");
        }

        public static bool ValidateIsbn(string input)
        {

            var inputNoDashes = input.Replace("-", "").Trim();
            if (inputNoDashes.Length == 10)
            {
                return Validate10DigitIsbn(inputNoDashes);
            }
            else if (inputNoDashes.Length == 13)
            {
                return Validate13DigitIsbn(inputNoDashes);
            }
            else
            {
                return false;
            }
        }

        public static bool Validate10DigitIsbn(string input)
        {
            if (input.Length != 10)
                return false;

            var sum = 0;

            for (int i = 1; i <= 10; i++)
            {
                int currentDigit;
                char currentChar = input[i - 1];

                if (i == 10 && (currentChar == 'X' || currentChar == 'x'))
                {
                    currentDigit = 10;
                }
                else if (!Int32.TryParse(currentChar.ToString(), out currentDigit))
                {
                    return false;
                }

                sum += (i * currentDigit);
            }
            return sum % 11 == 0;
        }

        public static bool Validate13DigitIsbn(string input)
        {
            if (input.Length != 13)
                return false;

            var sum = 0;

            for (int i = 1; i <= 13; i++)
            {
                int currentDigit;
                char currentChar = input[i - 1];

                if (i == 13 && (currentChar == 'X' || currentChar == 'x'))
                {
                    currentDigit = 10;
                }
                else if (!Int32.TryParse(currentChar.ToString(), out currentDigit))
                {
                    return false;
                }
                else if (i % 2 == 0)
                {
                    currentDigit = currentDigit * 3;
                }

                sum += currentDigit;
            }
            return sum % 10 == 0;
        }
    }
}
