using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections1
{
    internal class Kelvin
    {
        public float Degree { get; set; }

        public   void Degrees(string[] args)
        {
            Console.WriteLine("Enter amount  of celcius");
            int celcius = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Kelvin ={0}", (celcius + 273));

        }
    }
}
