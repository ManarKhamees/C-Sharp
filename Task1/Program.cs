using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1)
            Console.WriteLine("Please enter a string :");
            string str1 = Console.ReadLine();
            Console.WriteLine(str1);

            //-----------------------------------------------------------
            //2)
            Console.WriteLine("-----------------------------------------");
            double a = 1.1;
            string b = "Hi";
            char c = 'c';
            bool d = false;
            const int e = 5;

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);

            //-----------------------------------------------------------
            //3)
            Console.WriteLine("-----------------------------------------");
            string[] car = { "BYD", "BMW", "Changan", "Mercedes" };
            for (int i = 0; i < car.Length; i++)
            { 
                Console.WriteLine(car[i]); 
            }
            Console.WriteLine(car.Length);

            //-----------------------------------------------------------
            //4)
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Enter your first name :");
            string fname = Console.ReadLine();
            Console.WriteLine("Enter your last name :");
            string lname = Console.ReadLine();
            Console.WriteLine("Enter your birth year :");
            string birthyear = Console.ReadLine();

            Console.WriteLine(fname + " " + lname + " " + birthyear);

            //-----------------------------------------------------------
            //5)
            Console.WriteLine("-----------------------------------------");
            int[] arr = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.Write("Elements in the array are : ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
            }

            //-----------------------------------------------------------
            //6)
            Console.WriteLine("\n-----------------------------------------");
            int[] arr2 = { 2, 5, 8 };
            int sum = 0;
            for (int i = 0; i < arr2.Length; i++)
            {
                sum += arr2[i];
            }
            Console.WriteLine("The sum of all elements stored in the array is : " + sum);
        }
    }
}
