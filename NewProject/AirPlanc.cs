using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewProject
{
    internal class AirPlanc : ITransport
    {
        public string ShipTime { get; set; }
        public decimal MaxW { get; set; } = 100000;
        public decimal MinW { get; set; } = 100;
        public decimal CountRes { get ; set; }


        public void AirPlansCountRes(int x)
        {
            switch (x)
            {
                case < 40000:
                    {
                        CountRes = 500;
                        ShipTime = "2 day";
                        Console.WriteLine("cost = " + CountRes + "$");
                        Console.WriteLine("will arrive in " + ShipTime);
                        break;
                    }
                case < 70000:
                    {
                        CountRes = 1000;
                        ShipTime = "2 day";
                        Console.WriteLine("cost = " + CountRes + "$");
                        Console.WriteLine("will arrive in " + ShipTime);
                        break;
                    }
                case < 100000:
                    {
                        CountRes = 1500;
                        ShipTime = "3 day";
                        Console.WriteLine("cost = " + CountRes + "$");
                        Console.WriteLine("will arrive in " + ShipTime);
                        break;
                    }

            }


        }

        
    }
}
