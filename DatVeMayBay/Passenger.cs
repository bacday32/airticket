using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatVeMayBay
{
    class Passenger : Person
    {
        // AirTicket ticket = new AirTicket();
        private int numbertrip { get; set; }
        public AirTicket airTicket { get; set; }
        public Passenger(string fullname, string sex, int yearold, int numbertrip, AirTicket airTicket) : base(fullname, sex, yearold)
        {
            this.numbertrip = numbertrip;
            this.airTicket = airTicket;
        }
        public Passenger()
        {
        }
        public override string ToString()
        {
            return this.fullname + " : " + this.sex + " : " + this.yearold + " : " + this.airTicket;
        }
    }
}
