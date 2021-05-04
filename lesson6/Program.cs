using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson6
{
    class Program
    {
        static string name;

        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.SetRatuSkaicius(4);
            myCar.SetRatuSkaicius(6);

            name = "Modestas";

            //myCar.SetColor("blue");
            //myCar.SetColor("black");
            //string color = myCar.Color;

        }
    }
}