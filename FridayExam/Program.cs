using System;
using System.Collections.Generic;

namespace FridayExam
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question 1

            int[] nums = new int[] { 1, 1, 1 };
            int operations = MinOperations(nums);
            Console.WriteLine("Minium operations Required are {0}", operations);
            Console.WriteLine();
            Console.WriteLine();

            //Question 2

            string s = "abbaca";
            Console.WriteLine("Final After removing duplicates is {0}", RemoveDuplicates(s));

            Console.WriteLine();
            Console.WriteLine();

            //Question 3

            string[] words =  { "bella", "label", "roller" };
            List<char> common_words = CommonChars(words);
            Console.WriteLine("Common characters are:");
            foreach(char c in common_words)
            {
                Console.Write(c + " ");
            }

            Console.WriteLine();
            Console.WriteLine();


            //Question 4

            string text = "mumacollegeofbusiness";
            Console.WriteLine("Number of USF strings that can be constructed are {0}", CountUsf(text));
            Console.WriteLine();
            Console.WriteLine();

            //Question 5

            string s1 = "anagram";
            string t = "nagaram";
            Console.WriteLine("Given two strings are {0}", IsAnagram(s1, t));
            Console.WriteLine();
            Console.WriteLine();

        }

        //Question 1

        public static int MinOperations(int[] arr)
        {
            try
            {

                return 0;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        //Question 2

        public static string RemoveDuplicates(string s)
        {
            try
            {
                return "";
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        //Question 3

        public static List<char> CommonChars(string[] words)
        {
            List<char> common_words = new List<char>();

            try
            {
                return common_words;

            }
            catch(Exception e)
            {
                throw e;
            }
        }

        //Question 4

        public static int CountUsf(string s)
        {
            try
            {
                return 0;
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        //Question 5

        public static bool IsAnagram(string s , string t)
        {
            try
            {
                return false;
            }
            catch(Exception e)
            {
                throw e;
            }
        }
    }
}
