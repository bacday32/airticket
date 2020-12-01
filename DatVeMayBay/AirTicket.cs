using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatVeMayBay
{
    class AirTicket
    {
        public int idticket { get; set; }
        public string nametrip { get; set; }
        public string dayflight { get; set; }
        public float price { get; set; }
        public AirTicket(int idticket, string nametrip, string dayflight, float price)
        {
            this.idticket = idticket;
            this.nametrip = nametrip;
            this.dayflight = dayflight;
            this.price = price;
        }

        public AirTicket()
        {           
        }         
        public override string ToString()
        {
            return this.idticket + ":" + this.nametrip + ":" + this.dayflight + ":" + String.Format("{0:0.00}", this.price);
        }
    }
}
