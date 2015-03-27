using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise_Basics
{
    class Car
    {
        private string brand;

        public Car(string newBrand)
        {
            brand = newBrand;
        }

        public void Drive()
        {
            Console.WriteLine(brand);
            Console.WriteLine("Were Driving");
            
        }
    }
        
}
