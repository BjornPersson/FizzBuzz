using System.Globalization;

namespace FizzBussConsole
{
    public class FizzBuzz
    {
        public static string GetStringFor(int number)
        {
            var numberDividedBy3 = number / 3;
            if (IsDivisableBy3(number) && IsDivisableBy5(numberDividedBy3))
                return "FizzBuzz";

            if (IsDivisableBy3(number))
                return "Fizz";

            if (IsDivisableBy5(number))
                return "Buzz";

            return number.ToString(CultureInfo.InvariantCulture);
        }

        private static bool IsDivisableBy5(int numberDividedBy3)
        {
            return numberDividedBy3 % 5 == 0;
        }

        private static bool IsDivisableBy3(int number)
        {
            if (number % 3 == 0) return true;
            return false;
        }
    }
}