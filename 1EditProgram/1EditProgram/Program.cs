using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstString = "Madhus";
            string secondString = "Madhu";
            if (firstString.Length == secondString.Length)
            {
                Console.WriteLine(findIfReplace(firstString, secondString));
            }
            else if (firstString.Length - 1 == secondString.Length)
            {
                Console.WriteLine(findIfInsert(firstString, secondString));

            }
            else if (firstString.Length == secondString.Length - 1)
            {
                Console.WriteLine(findIfSecond(secondString, firstString));
            }
            else
            {
                Console.WriteLine(false);
            }
            Console.ReadLine();
        }
        private static bool findIfInsert(string firstString, string secondString)
        {
            int index1 = 0;
            int index2 = 0;

            bool setFalseFlag = false;

            while (index1 < firstString.Length && index2 < secondString.Length)
            {
                if (firstString[index1] != secondString[index2])
                {
                    if (setFalseFlag)
                    {
                        index1++;
                        return false;
                    }
                    setFalseFlag = true;

                }
                index1++;
                index2++;
            }
            return true;

        }

        private static bool findIfSecond(string firstString, string secondString)
        {
            int index1 = 0;
            int index2 = 0;

            bool setFalseFlag = false;

            while (index1 < firstString.Length && index2 < secondString.Length)
            {
                if (firstString[index1] != secondString[index2])
                {
                    if (setFalseFlag)
                    {
                        index1++;
                        return false;
                    }
                    setFalseFlag = true;

                }
                index1++;
                index2++;
            }
            return true;
        }

        private static bool findIfReplace(string firstString, string secondString)
        {
            bool setfalseFlag = false;
            for (int i = 0; i < firstString.Length; i++)
            {
                if (firstString[i] != secondString[i])
                {
                    if (setfalseFlag)
                    {
                        return false;
                    }

                    setfalseFlag = true;
                }
            }
            return true;
        }
    }
}