using System;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            {
                int setchik = 0;
                string sstroka = "js";
                string jstroka = "jjssccd";
                char[] stroka1 = sstroka.ToCharArray();
                char[] stroka2 = jstroka.ToCharArray();
                for (int i = 0; i < stroka2.Length; i++)
                {
                    if (stroka1[0] == stroka2[i])
                    {
                        setchik++;
                    }
                    if (stroka1[1] == stroka2[i])
                    {
                        setchik++;
                    }
                }

                Console.WriteLine(setchik);
            }
        }
    }
}