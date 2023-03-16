using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewProject
{
    internal class Truck : ITransport
    {
        public string ShipTime { get; set; }
        public decimal MaxW { get; set; } = 10000;
        public decimal MinW { get; set; } = 1;
        public decimal CountRes { get; set; }

        public void TruckCountRes(int x)
        {
            switch (x)
            {
                case < 4000:
                    {
                        CountRes = 500;
                        ShipTime = "2 Saturday";
                        Console.WriteLine("cost = " + CountRes + "$");
                        Console.WriteLine("will arrive in " + ShipTime);
                        break;
                    }
                case < 7000:
                    {
                        CountRes = 1000;
                        ShipTime = "2 Saturday";
                        Console.WriteLine("cost = " + CountRes + "$");
                        Console.WriteLine("will arrive in " + ShipTime);
                        break;
                    }
                case < 10000:
                    {
                        CountRes = 1500;
                        ShipTime = "3 Saturday";
                        Console.WriteLine("cost = " + CountRes + "$");
                        Console.WriteLine("will arrive in " + ShipTime);
                        break;
                    }

            }


        }

       
    }
}
