using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            //ListPritatice();
            Car newCar = new Car("Toyota");
            newCar.Drive();
          

            Car newCar2 = new Car("Audi");
            newCar2.Drive();
            Console.ReadLine();

        }

        //public static void ListPritatice()
        //{
        //    List<string> Words = new List<string>();
        //    Words.Add("house");
        //    Words.Add("boat");
        //    Console.WriteLine(Words[1]);
        //    Console.ReadLine();
        //}
    }
}

