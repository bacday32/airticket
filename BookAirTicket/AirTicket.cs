using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookAirTicket
{
    class AirTicket
    {
        public int idTicket { get; set; }
        public string nameTrip { get; set; }
        public string dayFlight { get; set; }
        public float price { get; set; }
        public AirTicket(int idTicket, string nameTrip, string dayFlight, float price)
        {
            this.idTicket = idTicket;
            this.nameTrip = nameTrip;
            this.dayFlight = dayFlight;
            this.price = price;
        }

        public AirTicket()
        {           
        }         
        public override string ToString()
        {
            return this.idTicket + ":" + this.nameTrip + ":" + this.dayFlight + ":" + String.Format("{0:0.00}", this.price);
        }
    }
}
