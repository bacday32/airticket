using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookAirTicket
{
    class Passenger : Person
    {
        // AirTicket ticket = new AirTicket();
        public int numberTrip { get; set; }
        public AirTicket airTicket { get; set; }
        public Passenger(string fullName, string sex, int yearOld, int numberTrip, AirTicket airTicket) : base(fullName, sex, yearOld)
        {
            this.numberTrip = numberTrip;
            this.airTicket = airTicket;
        }
        public Passenger()
        {
        }
        public override string ToString()
        {
            return this.fullName + " : " + this.sex + " : " + this.yearOld + " : " + this.airTicket;
        }

    }
}
