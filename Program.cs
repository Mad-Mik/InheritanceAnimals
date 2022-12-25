using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAnimals
{
    class Program
    {
        static void Main(string[] args)
        {
            Animals animals = new Animals("Bobik");
            animals.Print();        // Bobik
                                    
            Dog employee = new Dog("HafHaf Guard");
            employee.Print();       //HafHaf Guard

            Animals animals2 = new Animals("Tom");
            animals2.Print();        // Tom

            Cat employee2 = new Cat("MyauMyau CatchMouse");
            employee2.Print();      //MyauMyau CatchMouse
        }

        class Animals
        {
            public string Name { get; set; }
            public Animals(string name)
            {
                Name = name;
            }
            public void Print()
            {
                Console.WriteLine(Name);
            }
        }
        class Dog : Animals
        {
            public string Guard { get; set; }
            public Dog(string name, string guard)
                : base(name)
            {
            }
            public Dog(string name)
                : base(name)
            {
            }
        }
        class Cat : Animals
        {
            public string CatchMouse { get; set; }
            public Cat(string name, string catchMouse)
               : base(name)
            {
                CatchMouse = catchMouse;
            }
            public Cat(string name)
                : base(name)
            {
            }
        }
    }
}

