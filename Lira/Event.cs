using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lira
{
    public class Event
    {
        public string TypeOfInstitution { get; set; }
        public string TypeOfIvent { get; set; }
        public DateTime TimeEvent { get; set; }
        public int CountTicket { get; set; }
        public int PriceTicket { get; set; }
    }
}
