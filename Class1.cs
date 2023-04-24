using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VER_2
{
    public class Class1
    {
        static void Main()
        {
            //Ü1//
            /*
            Console.WriteLine("Enter the string: ");
            string str = Console.ReadLine();



            int wordCount = 0;
            int spaceCount = 0;

            bool isSpace = true; // Флаг для определения, является ли текущий символ пробелом

            for (int i = 0; i < str.Length; i++)
            {
                char c = str[i];
                if (c == ' ')
                {
                    if (!isSpace)
                    {
                        wordCount++;
                    }
                    isSpace = true;
                    spaceCount++;
                }
                else
                {
                    isSpace = false;
                }
            }

            if (!isSpace)
            {
                wordCount++;
            }


            Console.WriteLine("Number of words: " + wordCount);
            Console.WriteLine("Number of spaces: " + spaceCount);
            */
            //Ü2//
            /*
            // Создание массива случайных целых чисел
            int[] arr = new int[10];
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(1, 101);
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();

            // Создание массивов с четными и нечетными числами
            int[] evenArr = new int[arr.Length];
            int evenCount = 0;
            int[] oddArr = new int[arr.Length];
            int oddCount = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    evenArr[evenCount] = arr[i];
                    evenCount++;
                }
                else
                {
                    oddArr[oddCount] = arr[i];
                    oddCount++;
                }
            }

            // Сортировка массивов по возрастанию
            Array.Sort(evenArr, 0, evenCount);
            Array.Sort(oddArr, 0, oddCount);

            // Вывод отсортированных массивов
            Console.WriteLine("Even numbers:");
            for (int i = 0; i < evenCount; i++)
            {
                Console.Write(evenArr[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Odd numbers:");
            for (int i = 0; i < oddCount; i++)
            {
                Console.Write(oddArr[i] + " ");
            }
            Console.WriteLine();
            */
            //Ü3//
            /*
            Console.Write("Enter the number: ");
            string input = Console.ReadLine();
            int[] digits = new int[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                digits[i] = int.Parse(input[i].ToString());
            }

            Console.WriteLine("Array of digits: " + string.Join(", ", digits));

            bool isSymmetric = true;
            bool isAllSame = true;
            bool isIncreasing = true;
            bool isDecreasing = true;

            for (int i = 0; i < digits.Length / 2; i++)
            {
                if (digits[i] != digits[digits.Length - i - 1])
                {
                    isSymmetric = false;
                }
            }

            for (int i = 1; i < digits.Length; i++)
            {
                if (digits[i] != digits[0])
                {
                    isAllSame = false;
                }
                if (digits[i] <= digits[i - 1])
                {
                    isIncreasing = false;
                }
                if (digits[i] >= digits[i - 1])
                {
                    isDecreasing = false;
                }
            }

            if (isSymmetric)
            {
                Console.WriteLine("The number is symmetrical.");
            }
            if (isAllSame)
            {
                Console.WriteLine("All digits are the same.");
            }
            if (isIncreasing)
            {
                Console.WriteLine("The digits of the number are arranged in ascending order.");
            }
            if (isDecreasing)
            {
                Console.WriteLine("The digits of the number are arranged in descending order.");
            }
            if (!isSymmetric && !isAllSame && !isIncreasing && !isDecreasing)
            {
                Console.WriteLine("The number is neither symmetrical, nor contains the same digits, nor is it arranged in ascending or descending order.");
            }
            */
        }
    }

}
