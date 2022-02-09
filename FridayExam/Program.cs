using System;
using System.Collections.Generic;

namespace FridayExam
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question 1

            int N = 6;
            PrintPattern(N);
            Console.WriteLine();
            Console.WriteLine();

            //Question 2

            int[] nums = new int[] { 1, 1, 1 };
            int operations = MinOperations(nums);
            Console.WriteLine("Minium operations Required are {0}", operations);
            Console.WriteLine();
            Console.WriteLine();

            //Question 3

            string[] words = {"eat","tea","tan","ate","nat","bat"};
            List<List<string>> groups = WordGroups(words);
            Console.WriteLine("Groups are ");
            foreach (List<string> G in groups)
            {
                foreach(string s in G )
                {
                    Console.Write(s + "  ");
                }
                Console.WriteLine();
                Console.WriteLine();

            }

            Console.WriteLine();
            Console.WriteLine();


        }

        //Question 1

        public static void PrintPattern(int N)
        {
            try
            {

            }
            catch (Exception e)
            {
                throw;
            }
        }

        //Question 2

        public static int MinOperations(int[] nums)
        {
            try
            {
                return 0;
            }
            catch (Exception e)
            {
                throw;
            }
        }

        //Question 3

        public static List<List<string>> WordGroups(string[] words)
        {
            List<List<string>> groups = new List<List<string>>();

            try
            {
                return groups;

            }
            catch (Exception e)
            {
                throw;
            }
        }
    }
}
