using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1 {
    class Worker
    {
        private string name, surname;
        private int days, rate;

        
        public void Set(string _name, string _surname, int _days, int _rate){
            name = _name;
            surname = _surname;
            days = _days;
            rate = _rate;
        }
        public void Get(){
            Console.WriteLine(days*rate);
        }
    }
    public class Program {
       
        public static void Main(string[] args)
        {
            Worker Aleksandr = new Worker();
            Aleksandr.Set("Sania","Dremov",5,40);

            Aleksandr.Get();
        
        
        }
    }
}