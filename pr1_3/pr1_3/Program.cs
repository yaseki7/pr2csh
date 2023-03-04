using System;

namespace ConsoleApp1
{
    public class Program
    {
        
        public static void Main(string[] args)
        {
            string str = ("false");
            int[] nums = { 1,1,2,2,3,4 };
            bool a = false;

            for (int i = 0; i < nums.Length-1; i++){
                for (int j = 1+i; j < nums.Length; j++)
                {
                    if (nums[i] == nums[j])
                    {
                        a = true;
                    }
                }
            }

            if (a == false) 
            { 
                str = "False";
            }
            else
            {
                str = "True";
            }
                
            Console.WriteLine(str);
        }
    }
}