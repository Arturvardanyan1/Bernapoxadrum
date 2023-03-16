using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewProject
{
    internal class OrderID : IDelivery
    {
        public string ShTime { get ; set ; }
        public long TrackingID { get ; set ; }
        public decimal ShippingCoast { get ; set ; }
        public string StartDate { get ; set; }
        public string EndDate { get ; set ; }
        
        public void OrderShTime(int x)
        {
            switch (x)
            {
                case 1:
                    {
                        ShTime = "1-3 Shabat";
                        Console.WriteLine(ShTime);
                        break;
                    } 
                case 2:
                    {
                        ShTime ="1-3 or";
                        Console.WriteLine(ShTime);
                        break;
                    }
                case 3:
                    {
                        ShTime = "1-3 amis";
                        Console.WriteLine(ShTime);
                        break;
                    }
            }
        }

        public void OrderTrackingID()
        {
            Random rand = new Random();            
            TrackingID = rand.Next(short.MaxValue);
            Console.WriteLine("TrackingID = " + TrackingID);
        }

        public void OrderShippingCoast(int x,int y)
        {
            switch (x)
            {
                case 1:
                    {
                        if(y < 5000)
                        {
                            ShippingCoast = 500;

                        }
                        else
                        {
                            ShippingCoast = 1000;
                        }
                        break;
                    }
                case 2:
                    {
                        if(y < 50000)
                        {
                            ShippingCoast = 1000;

                        }
                        else
                        {
                            ShippingCoast = 2500;
                        }
                        break;
                    }
                case 3:
                    {
                        if(y < 50000)
                        {
                            ShippingCoast = 1000;

                        }
                        else
                        {
                            ShippingCoast = 3000;
                        }
                        break;
                    }
            }
            Console.WriteLine("Shipping Coast = " + ShippingCoast);
        }

        public void OrderStartDate(int x)
        {
            switch (x)
            {
                case 1:
                    {
                        StartDate = "grancman oric 3 or heto";
                        Console.WriteLine(StartDate);
                        break;
                    }
                case 2:
                    {
                        StartDate = "grancman oric 5 or heto";
                        Console.WriteLine(StartDate);
                        break;
                    }
                case 3:
                    {
                        StartDate = "grancman oric 2 shabat heto";
                        Console.WriteLine(StartDate);
                        break;
                    }
            }
        }
    }
   


}
