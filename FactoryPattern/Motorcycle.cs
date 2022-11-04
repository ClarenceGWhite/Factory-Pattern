using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Motorcycle : IVehicle
    {
        public Motorcycle() 
        {
        }
 

        public void Drive() 
        {

            Console.WriteLine($"Driving a motorcycle can be dangerous.");

        }



    }
}
