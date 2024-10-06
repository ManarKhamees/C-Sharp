using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //------------------------------------Task2------------------------------------
            //1)
            int num1 = 4, num2 = 5;
            if (num1 < num2) 
            { Console.WriteLine(num1); }
            else if (num1 > num2)
            { Console.WriteLine(num2); }
            else { Console.WriteLine("The two numbers are equals !!"); }

            //------------------------------------
            //2)
            Console.WriteLine("-----------------------------------------");

            Console.WriteLine("Enter a number : ");
            int num3 = Convert.ToInt32(Console.ReadLine());
            if (num3 > 0)
            { Console.WriteLine("The sign is +"); }
            else if (num3 < 0)
            { Console.WriteLine("The sign is -"); }
            else { Console.WriteLine("The number is 0 !!"); }

            //------------------------------------
            //3)
            Console.WriteLine("-----------------------------------------");

            int temp;

            Console.Write("Enter the first number : ");
            int num4 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number : ");
            int num5 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the third number : ");
            int num6 = Convert.ToInt32(Console.ReadLine());

            if (num4 > num5)
            {
                temp = num4;
                num4 = num5;
                num5 = temp;
            }

            if (num5 > num6)
            {
                temp = num5;
                num5 = num6;
                num6 = temp;
            }

            if (num4 > num5)
            {
                temp = num4;
                num4 = num5;
                num5 = temp;
            }

            Console.WriteLine("The sorted numbers : {0}, {1}, {2}", num4, num5, num6);

            //------------------------------------
            //4)
            Console.WriteLine("-----------------------------------------");

            int num7 = 7, num8 = 8, num9 = 9, num10 = 10, num11 = 11;
            int max = num7;

            if (num8 > max)
            {
                max = num8;
            }

            if (num9 > max)
            {
                max = num9;
            }

            if (num10 > max)
            {
                max = num10;
            }

            if (num11 > max)
            {
                max = num11;
            }

            Console.WriteLine("The max number is : " + max);

            //------------------------------------
            //5)
            // Conversion factor from kilometers to miles
            Console.WriteLine("-----------------------------------------");

            const double conversionFactor = 0.621371;

            Console.Write("Input kilometers per hour: ");
            double kilometersPerHour = Convert.ToDouble(Console.ReadLine());

            // Convert to miles per hour
            double milesPerHour = kilometersPerHour * conversionFactor;

            Console.WriteLine("{0} kilometers per hour is equal to {1} miles per hour.", kilometersPerHour, milesPerHour);

            //------------------------------------
            //6)
            Console.WriteLine("-----------------------------------------");

            Console.Write("Input hours : ");
            int hours = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input minutes : ");
            int minutes = Convert.ToInt32(Console.ReadLine());

            int totalMinutes = (hours * 60) + minutes;
            Console.WriteLine("Total : {0} minutes", totalMinutes);

            //------------------------------------
            //7)
            Console.WriteLine("-----------------------------------------");

            Console.Write("Input minutes : ");
            int totalMinutes2 = Convert.ToInt32(Console.ReadLine());

            int hours2 = totalMinutes2 / 60;
            int minutes2 = totalMinutes2 % 60;

            Console.WriteLine("{0} Hours, {1} Minutes", hours2, minutes2);

            //------------------------------------
            //8)
            Console.WriteLine("-----------------------------------------");

            string[] sentences = new string[5] {
            "Manar Khamees",
            "Palestine will be free..",
            "This is C# !!",
            "Now I'm writing some sentences..",
            "The End !!"
            };

            int fixedLength = 25;

            foreach (string sentence in sentences)
            {
                // Use PadRight to ensure the sentence is printed with a fixed length
                Console.WriteLine(sentence.PadRight(fixedLength));
            }

            //------------------------------------
            //9)
            Console.WriteLine("-----------------------------------------");

            Console.Write("Enter a sentence : ");
            string input = Console.ReadLine();

            string[] words = input.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                // Check if the word has an odd length
                if (words[i].Length % 2 != 0)
                {
                    // Reverse the word with odd length
                    char[] charArray = words[i].ToCharArray();
                    Array.Reverse(charArray);
                    words[i] = new string(charArray);
                }
            }

            // Join the words back into a single string
            string result = string.Join(" ", words);

            Console.WriteLine(result);


            //------------------------------------Task2------------------------------------
            //1)
            Console.WriteLine("-----------------------------------------");

            string[] arr1 = { "1", "7", "9", "45" };
            string[] arr2 = { "Str", "alex", "moh" };
            string[] arr3 = { "the", "fox", "over", "lazy", "dog" };

            Console.WriteLine("The corrected Arrays :");
            Console.WriteLine(string.Join(", ", arr1));
            Console.WriteLine(string.Join(", ", arr2));
            Console.WriteLine(string.Join(", ", arr3));
            Console.WriteLine();

            //------------------------------------
            //2)
            Console.WriteLine("-----------------------------------------");

            string[] fruits = { "Tomato", "Banana", "Watermelon" };
            int tomatoIndex = Array.IndexOf(fruits, "Tomato");
            int bananaIndex = Array.IndexOf(fruits, "Banana");

            Console.WriteLine($"Index of 'Tomato' : {tomatoIndex}");
            Console.WriteLine($"Index of 'Banana' : {bananaIndex}");
            Console.WriteLine();

            //------------------------------------
            //3)
            Console.WriteLine("-----------------------------------------");

            string[] favFood = { "Shawerma", "Shawerma", "Shawerma", "Shawerma", "Shawerma" };
            string[] favSport = { "Tennis", "Football", "Basketball" };
            string[] favMovie = { "The Amazing Spider Man", "Red", "Ghosted", "Knives Out" };

            Console.WriteLine("My Favorite Food :");
            foreach (string food in favFood)
            {
                Console.WriteLine(food);
            }

            Console.WriteLine("\nMy Favorite Sports :");
            foreach (string sport in favSport)
            {
                Console.WriteLine(sport);
            }

            Console.WriteLine("\nMy Favorite Movies :");
            foreach (string movie in favMovie)
            {
                Console.WriteLine(movie);
            }

            Console.WriteLine();

            //------------------------------------
            //4)
            Console.WriteLine("-----------------------------------------");

            Console.Write("Input three numbers separated by comma : ");
            string input2 = Console.ReadLine();
            string[] nums = input2.Split(',');

            int sum = 0;
            foreach (string num in nums)
            {
                sum += int.Parse(num.Trim());
            }

            Console.WriteLine("The sum of the three numbers : " + sum);
            Console.WriteLine();

            //------------------------------------
            //5)
            Console.WriteLine("-----------------------------------------");

            int oddSum = 0;
            Console.Write("The odd numbers are : ");

            for (int i = 1; i <= 100; i += 2)
            {
                Console.Write(i + " ");
                oddSum += i;
            }

            Console.WriteLine("\nThe Sum of odd Numbers is : " + oddSum);
            Console.WriteLine();

            //------------------------------------
            //6)
            Console.WriteLine("-----------------------------------------");

            int rows = 3;

            Console.WriteLine("Asterisk Pattern :");
            for (int i = 1; i <= rows; i++)
            {
                for (int j = rows; j > i; j--)
                {
                    Console.Write(" ");
                }

                for (int k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            //------------------------------------
            //7)
            Console.WriteLine("-----------------------------------------");

            int num12 = 1;

            Console.WriteLine("Number Pattern :");
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 4; j > i; j--)
                {
                    Console.Write(" ");
                }

                for (int k = 1; k <= i; k++)
                {
                    Console.Write(num12 + " ");
                    num12++;
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
    }