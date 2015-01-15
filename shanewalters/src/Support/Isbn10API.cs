using System;
using System.Linq;

namespace Support
{
    public static class Isbn10API
    {
        public const int ISBN_10_MAX_DIGITS = 10;
        private static Random rand = new Random();

        public static bool IsValid(string isbn)
        {
            // Get the sum of the ISBN-10 parts
            var sum = GetSum(isbn);

            // It is valid if the sum is greater than zero and evenly divisible by 11
            return sum > 0 && sum % 11 == 0;
        }

        public static string Generate()
        {
            var result = string.Empty;

            for (var i = 0; i < 9; i++)
            {
                result += rand.Next(0, 10).ToString();
            }

            var sum = GetSum(result + "0");
            var amountToAdd = 11 - (sum % 11);

            if (amountToAdd == 11)
            {
                amountToAdd = 0;
            }

            return result + Convert(amountToAdd);
        }

        private static int GetSum(string isbn)
        {
            var result = 0;

            // Ensure the input is valid
            if (IsValidFormat(isbn))
            {
                // Strip out stuff that doesn't matter
                var cleaned = new string(isbn.Where(x => CanCount(isbn, x)).ToArray());

                // Our position counter
                var start = ISBN_10_MAX_DIGITS;

                // Sum up all the numbers while decrementing our position multiplier
                result = cleaned.Sum(x => start-- * GetInteger(x));
            }

            return result;
        }

        private static string Convert(int value)
        {
            var result = string.Empty;

            if (value < 0 || value > 10)
            {
                throw new ArgumentOutOfRangeException("value");
            }

            if (value == 10)
            {
                result = "X";
            }
            else
            {
                result = value.ToString();
            }

            return result;
        }

        private static int GetInteger(char c)
        {
            int result = 0;

            if (char.IsDigit(c))
            {
                result = int.Parse(c.ToString());
            }
            else if (IsX(c))
            {
                result = 10;
            }

            return result;
        }

        private static bool IsValidFormat(string isbn)
        {
            return !string.IsNullOrWhiteSpace(isbn)
                && HasTenDigits(isbn);
        }

        private static bool CanCount(string isbn, char c)
        {
            return char.IsDigit(c)
                || (IsX(c) && IsCharInLast(isbn, c) && IsOnlyChar(isbn, c));
        }

        private static bool HasTenDigits(string isbn)
        {
            return isbn != null
                && isbn.Count(x => CanCount(isbn, x)) == ISBN_10_MAX_DIGITS;
        }

        private static bool IsX(char c)
        {
            return c == 'X' || c == 'x';
        }

        private static bool IsCharInLast(string isbn, char c)
        {
            return isbn != null && isbn.IndexOf(c) == isbn.Length - 1;
        }

        private static bool IsOnlyChar(string isbn, char c)
        {
            return isbn != null && isbn.Count(x => x == c) == 1;
        }
    }
}
