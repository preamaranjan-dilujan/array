using System;

namespace MyConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            sumOfPrimeNumber(10, 20);

        }

        private static void FindSmallestElement(int[] numbers)
        {
            int smallestElement = numbers[0];
            foreach (int num in numbers)
            {
                if (num < smallestElement)
                {
                    smallestElement = num;
                }
            }
            Console.WriteLine("Smallest element: " + smallestElement);
        }

        private static void PrintElementsAlternateOrder(int[] numbers)
        {
            Console.WriteLine("Array elements in alternate order:");
            for (int i = 0; i < numbers.Length; i += 2)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();
        }

        private static void FindElement(int[] numbers, int target)
        {
            foreach (int num in numbers)
            {
                if (num == target)
                {
                    Console.WriteLine("Element found: " + num);
                    return;
                }
            }
            Console.WriteLine("Element not found.");
        }

        private static bool PalindromeArray(int[] numbers)
        {
            int left = 0;
            int right = numbers.Length - 1;
            while (left < right)
            {
                if (numbers[left] != numbers[right])
                {
                    return false;
                }
                left++;
                right--;
            }
            return true;
        }

        private static void MinMaxProduct(int[] arr1, int[] arr2)
        {
            if (arr1.Length == 0 || arr2.Length == 0)
            {
                Console.WriteLine("One or both arrays are empty.");
                return;
            }

            int max1 = arr1[0];
            int min2 = arr2[0];
            foreach (int num in arr1)
            {
                if (num < max1) max1 = num;
            }

            foreach (int num in arr2)
            {
                if (num < min2) min2 = num;
            }

            int product1 = max1 * min2;

            Console.WriteLine("Product of max1 and min2: " + product1);
        }

        private static void sumOfPrimeNumber(int left, int right)
        {
            //Note: Use sieve of eratosthenes to solve the problem
            int sum = 0;
            int[] arr = new int[right + 1];
            int root = (int)Math.Sqrt(arr.Length);

            for (int i = 0; i <= right; i++)
            {
                arr[i] = 1;
            }
            
            for (int i = 2; i <= root; i++)
            {
                for (int j = i * 2; j < arr.Length; j += i)
                {
                    arr[j] = 0;
                }
            }
            for (int i = left; i <= right; i++)
            {
                if (arr[i] == 1)
                {
                    sum += i;
                }
            }
            Console.WriteLine("Sum of prime numbers between " + left + " and " + right + ": " + sum);
        }

        private static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }

    }


}