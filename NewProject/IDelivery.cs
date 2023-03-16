using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewProject
{
    internal interface IDelivery
    {
        string ShTime { get; set; }
        long TrackingID { get; set; }
        decimal ShippingCoast { get; set; }
        string StartDate { get; set; }
        string EndDate { get; set; }
       
       


    }
}
