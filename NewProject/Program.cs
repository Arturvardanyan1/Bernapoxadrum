namespace NewProject
{
    internal class Program 
    {
        static void Main(string[] args)
        {
            int weght=int.Parse(Console.ReadLine());

            switch (weght)
            {
                case <100:
                    {
                        Console.WriteLine("1. Truck");
                        break;
                    }
                case <1000:
                    {
                        Console.WriteLine("1. Truck " + "2. AirPlanc");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("1. Truck " + "2. AirPlanc " + "3. Ship");
                        break;
                    }

            }
            Console.WriteLine("Yntrel tarberakneri hamarneric meky");
            byte i=byte.Parse(Console.ReadLine());
            switch (i)
            {
                case 1:
                    {
                        Truck truck = new Truck();
                        truck.TruckCountRes(weght);
                        break;
                    }
                case 2:
                    {
                        AirPlanc airPlanc = new AirPlanc();
                        airPlanc.AirPlansCountRes(weght);
                        break;
                    }
                case 3:
                    {
                        Ship ship = new Ship();
                        ship.ShipCountRes(weght);
                        break;
                    }
            }
            OrderID orderID = new OrderID();
            orderID.OrderShTime(i);
            orderID.OrderTrackingID();
            orderID.OrderShippingCoast(i, weght);
            orderID.OrderStartDate(i);




        }
       
    }
}