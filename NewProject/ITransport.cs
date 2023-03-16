using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewProject
{
    internal interface ITransport
    {
        string ShipTime { get; set; }
        decimal MaxW { get; set; }
        decimal MinW { get; set; }
        decimal CountRes { get; set; }

        
    }

    
}
