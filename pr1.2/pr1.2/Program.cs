using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

public class Example
{
    public static void Main()
    {
        int[] candidates = new int[] { 10, 1, 2, 7, 6, 1, 5 };
        
        string str = String.Join(", ", candidates);
        string str2 = str;
        int tagret = 8;
        
        for (int i = 0; i < candidates.Length; i++)
        {
            for (int j = i + 1; j < candidates.Length; j++)
            {
                for(int k = j + 1 ; k<candidates.Length;k++){
                    
                    if (str[i] + str[j] == tagret)
                    {
                          
                        Console.Write($"{str[i]},{str[j]}\n");
                        int delete1 = str[i];
                        int delete2 = str[j];
                        str.Remove(str[i],1); // элемент/сколько
                        str.Remove(str[j],1);
                    }
                    else if (str2[i]+str2[j]+str2[k] == tagret)
                    {
                        Console.Write($"{str2[i]},{str2[j]},str2[k]\n");
                        int delete11 = str2[i];
                        int delete12 = str2[j];
                        int delete13 = str2[k];
                        str2.Remove(str2[i],1);
                        str2.Remove(str2[j],1);
                        str2.Remove(str2[k],1);
                    }
                }
            }
        }
    }
}