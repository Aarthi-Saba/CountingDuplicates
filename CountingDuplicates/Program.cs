using System;
using System.Collections.Generic;
using System.Linq;

namespace CountingDuplicates
{
    public class Program
    {
        public static void Main(string[] args)
        {
            DuplicateCount("");
            DuplicateCount("abcde");
            DuplicateCount("aabbcde");
            DuplicateCount("aabBcde");
            DuplicateCount("Indivisibility");
            //DuplicateCount("Indivisibilities");
            DuplicateCount("Aa2112");
        }
        public static int DuplicateCount(string str)
        {
            int count = str.ToUpper().GroupBy(i => i).Count(l => l.Count() > 1);
            //List<string> temp = new List<string>();
            //string input = str.ToUpper();
            //for(int i =0;i < input.Length;i++)
            //{
            //    for(int j=i+1; j < input.Length; j++)
            //    {
            //        if(input[i] == input[j] && !temp.Contains(input[i].ToString()))
            //        {
            //            temp.Add(input[i].ToString());
            //            count += 1;
            //            break;
            //        }
            //    }
            //}
            Console.WriteLine($"Count {count}");
            return count;
        }
    }
}
