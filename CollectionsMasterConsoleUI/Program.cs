using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        

        static void Main(string[] args)
        {
            //TODO: Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utlilize the method stubs at the bottom for the methods you must create ⬇⬇⬇

            #region Arrays
            //TODO: Create an integer Array of size 50
            var digits = new int[50];
            

            //TODO: Create a method to populate the number array with 50 random numbers that are between 0 and 50
            Populater(digits);

            //TODO: Print the first number of the array
            Console.WriteLine($"{digits[0]} first index");

            //TODO: Print the last number of the array
            Console.WriteLine($"{digits[digits.Length-1]} last index");

            Console.WriteLine("All Numbers Original");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(digits);
            Console.WriteLine("-------------------");

            //TODO: Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*  1) First way, using a custom method => Hint: Array._____(); 
                2) Second way, Create a custom method (scroll to bottom of page to find ⬇⬇⬇)
            */



            Console.WriteLine("All Numbers Reversed:");

            Console.WriteLine("---------REVERSE CUSTOM------------");
            ReverseArray(digits);

            Console.WriteLine("-------------------");

            //TODO: Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            Console.WriteLine("Multiple of three = 0: ");

            Console.WriteLine("-------------------");
            ThreeKiller(digits);

            //TODO: Sort the array in order now
            /*      Hint: Array.____()      */


            Console.WriteLine("Sorted numbers:");
            
            Array.Sort(digits);
            NumberPrinter(digits);

            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //TODO: Create an integer List
            var digiList = new List<int>();

            //TODO: Print the capacity of the list to the console
            Console.WriteLine($"Capacity: {digiList.Capacity}");

            //TODO: Populate the List with 50 random numbers between 0 and 50 you will need a method for this            
            Populater(digiList);

            //TODO: Print the new capacity
            Console.WriteLine($"New Capacity: {digiList.Capacity}");

            Console.WriteLine("---------------------");

            //TODO: Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!
            

            
            bool inList;
            int searchedNumber  ;

            do
            {
                Console.WriteLine("What number will you search for in the number list?");
                inList = int.TryParse(Console.ReadLine(), out searchedNumber);

            } 
            while (inList = false);

            NumberChecker(digiList, searchedNumber);

            
            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(digiList);
            Console.WriteLine("-------------------");


            //TODO: Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Evens Only!!");
            
            Console.WriteLine("------------------");
            
            OddKiller(digiList);

            Console.WriteLine("------------------");


            //TODO: Sort the list then print results
            Console.WriteLine("Sorted Evens!!");
            digiList.Sort();
            NumberPrinter(digiList);
            
            Console.WriteLine("------------------");

            //TODO: Convert the list to an array and store that into a variable
            var myDigiArray = digiList.ToArray();
            Console.WriteLine($"Evens converted to an array has {digiList.Count} containers");

            //TODO: Clear the list
            digiList.Clear();
            Console.WriteLine($"Capacity: {digiList.Capacity}");

            #endregion
        }

        private static void ThreeKiller(int[] digits)
        {
            for (int digi = 0; digi < digits.Length; digi++)
            {
                if (digits[digi] % 3 == 0)
                {
                    digits[digi] =0;
                }
                
            }
            NumberPrinter(digits);
        }

        private static void OddKiller(List<int> digiList)
        {
            for(int digit = digiList.Count-1; digit >=0; digit--) 
            {
                if (digiList[digit] % 2 !=0)
                digiList.Remove(digiList[digit]);
            }
            
            NumberPrinter(digiList);
        }

        private static void NumberChecker(List<int> digiList, int searchedNumber)
        {
            if(digiList.Contains(searchedNumber))
            {
                Console.WriteLine($"Yes we have the number {searchedNumber} you're looking for");
            }
            else
            {
                Console.WriteLine($"We do not have the number {searchedNumber}");
            }
        }

        private static void Populater(List<int> digiList)
        {
            while(digiList.Count <= 50)
            {
                Random rng = new Random();
                var digit = rng.Next(0, 50);
                digiList.Add(digit);
            }
            NumberPrinter(digiList);
        }

        private static void Populater(int[] digits)
        {
            Random rng = new Random();
            for (int digi = 0; digi < digits.Length; digi++)
            {
                digits[digi] = rng.Next(0, 50);
            }

        }        

        private static void ReverseArray(int[] array)
        {
            Array.Reverse(array);
            NumberPrinter(array);
        }

        /// <summary>
        /// Generic print method will iterate over any collection that implements IEnumerable<T>
        /// </summary>
        /// <typeparam name="T"> Must conform to IEnumerable</typeparam>
        /// <param name="collection"></param>
        private static void NumberPrinter<T>(T collection) where T : IEnumerable<int>
        {
            //STAY OUT DO NOT MODIFY!!
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
