using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;

namespace ConsoleApp1
{
    class Storage
    {
        public int scetchik1;

        public void writeInConsoleInfo(int scetchik1)
        {
            Console.WriteLine(scetchik1);
        }


    }

    public class Program
    {

        public static void Main(string[] args)
        {
            Storage Schetov = new Storage();
            Schetov.scetchik1 = 0;
            bool b = true;

            do
            {
                Console.WriteLine("Введите 1 для прибавление единицы, 2 для уменьшения на единицу, 3 для вывода числа");
                string a = Console.ReadLine();

                switch (a)
                {
                    case "1":
                        Schetov.scetchik1 = Schetov.scetchik1 + 1;
                        break;
                    case "2":
                        Schetov.scetchik1 = Schetov.scetchik1 - 1;
                        break;
                    case "3":
                        Console.Write($"Текущий счетчик = {Schetov.scetchik1}");
                        b = false;
                        break;
                }
            } while (b);
        }
    }
}