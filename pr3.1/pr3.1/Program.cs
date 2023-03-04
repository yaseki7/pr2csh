using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1 {
    class Worker
    {
        public string name, surname;
        public int days, rate;

        public void GetSalary()
        {
            Console.WriteLine($"{days * rate}");
        }
    }
    public class Program {
       
        public static void Main(string[] args)
        {
            Worker Aleksandr = new Worker();
            Aleksandr.name = "Sania";
            Aleksandr.surname = "Dremov";
            Aleksandr.days = 5;
            Aleksandr.rate = 40;
            Aleksandr.GetSalary();
        }
    }
}