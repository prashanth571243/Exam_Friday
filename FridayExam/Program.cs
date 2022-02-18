using System;
using System.Collections.Generic;

namespace FridayExam
{
    class Program
    {
        private static int i;

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

        public static int PrintPattern(int N)
        {
            
            int i = 0;
            int j = 0;
            

          

            try
            {
                for (i = N; i < N; ++i)
                {
                    for(j=1;j<=i;++j)
                    {
                      Console.Write("*");
                    }
                    Console.WriteLine();
                }
                return -1;
                
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
                int i = 0;
                int j = 0;
                int count = 0;
                int result = 0;
                int prev1 = 0;


                for (i = 0; i < nums.Length; i++)
                {
                    for (j = 0; j < nums.Length; j++)
                    {
                        if (nums[i] < nums[i + 1])
                        {
                            count = nums[i];
                        }
                        if (count == nums[i] && count > prev1)
                        {
                            result = count;
                            prev1 = count;
                        }

                    }
                }

                return result;
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
                Array.Sort(words);
                for (i = 0; i < words.Length; i++)
                {
                    for (j = 0; j < words.Length; j++)
                    {
                        if (words[i] = words[j]) ;
                    }
                 
                }

                return groups;
            }
            catch (Exception e)
            {
                throw;
            }
        }
    }
}
