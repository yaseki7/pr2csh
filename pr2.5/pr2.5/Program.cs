using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WaitForPendingFinalizersExample
{
    class Person 
    {
        public string name;
        public int age;
        public Person()
        {
            Console.WriteLine("Создание объекта Person");
            name = "Tom";
            age = 37;
        }
        public void Print()
        {
            Console.WriteLine($"Имя: {name}  Возраст: {age}");
        }
    }
    
    class MyWaitForPendingFinalizersClass
    {
  
        const int numMfos = 1000;
   
        const int maxIterations = 100;

        static void Main(string[] args)
        {
            string isxname = tom.name;
            int isxage = tom.age;
            Person tom = new Person();
            Console.WriteLine("1 для вывода, 2 для отчистки, 3 для сброса к исходу");
            string a = Console.ReadLine();
      
            switch(a){
                case "1":
                    tom.Print();
                    break;
                case "2":
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    for(int i = 0; i < maxIterations; i++)
                    {
                        Console.WriteLine("Doing some post-finalize work");
                    }
                    MyFinalizeObject mfo = null;
                    for(int j = 0; j < numMfos; j++)
                    {
                        mfo = new MyFinalizeObject();
                    }
                    mfo = null;
                    break;
                case "3":
                    isxname = tom.name;
                    isxage = tom.age;
                    break;
            }
        }
    }

    class MyFinalizeObject
    {

        private const int maxIterations = 1;

        ~MyFinalizeObject()
        {
            Console.WriteLine("Finalizing a MyFinalizeObject");
            
     
            for(int i = 0; i < maxIterations; i++)
            {
                GC.KeepAlive(i);
            }
        }
    }
}