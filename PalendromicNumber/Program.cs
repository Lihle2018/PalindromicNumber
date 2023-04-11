using System;

class Program
{
    static void Main(string[] args)
    {
        //Explanation:

       // The program first reads in the integer parameter n from the command line arguments.It then calculates the minimum and maximum n-digit numbers(minNum and maxNum) using the Math.Pow() function.

       //The program then initializes the largestPalindrome variable to 0, and loops through all possible pairs of n-digit numbers using two nested for loops.

       //For each pair of numbers, it calculates their product and checks if it is a palindrome using the IsPalindrome() function.If the product is a palindrome and larger than the current largestPalindrome, it updates the largestPalindrome variable.

       //Finally, the program outputs the largest palindrome found.The IsPalindrome() function works by converting the number to a string and comparing the characters at each end of the string until the middle is reached.
        Console.Write("n: ");
        int n = int.Parse(Console.ReadLine());
        int maxNum = (int)Math.Pow(10, n) - 1;
        int minNum = (int)Math.Pow(10, n - 1);

        int largestPalindrome = 0;

        for (int i = maxNum; i >= minNum; i--)
        {
            for (int j = maxNum; j >= minNum; j--)
            {
                int product = i * j;

                if (IsPalindrome(product) && product > largestPalindrome)
                {
                    largestPalindrome = product;
                }
            }
        }

        Console.WriteLine("The largest palindrome made from the product of two " + n + "-digit numbers is " + largestPalindrome);
    }

    static bool IsPalindrome(int number)
    {
        string numberString = number.ToString();
        int length = numberString.Length;

        for (int i = 0; i < length / 2; i++)
        {
            if (numberString[i] != numberString[length - i - 1])
            {
                return false;
            }
        }

        return true;
    }
}
