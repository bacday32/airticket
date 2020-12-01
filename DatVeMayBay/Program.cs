using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatVeMayBay
{
    class Program
    {
        static void Main(string[] args)
        {

            List<AirTicket> listticket = new List<AirTicket>
            {
                new AirTicket {idticket = 1, nametrip ="da nang - ho chi minh", dayflight= "1/12/2020" , price = 10000000.0F},
                new AirTicket {idticket = 2, nametrip ="da nang - ho chi minh", dayflight= "2/12/2020" , price = 15000000.0F},
                new AirTicket {idticket = 3, nametrip ="da nang - ho chi minh", dayflight= "3/12/2020" , price = 30000000.0F},
                new AirTicket {idticket = 4, nametrip ="da nang - ho chi minh", dayflight= "4/12/2020" , price = 20000000.0F},
                new AirTicket {idticket = 5, nametrip ="da nang - ho chi minh", dayflight= "5/12/2020" , price = 50000000.0F}

            };
            Console.Write("You want buy Air Ticket? YES/NO ?");
            string a = Convert.ToString(Console.ReadLine());
            //AirTicket newticket = new AirTicket();
            listticket.ForEach(x => { Console.WriteLine(x); });
            Console.WriteLine("Which idtrip do you want to go");
            int idtrip = int.Parse(Console.ReadLine());
            // get ticket with idtrip
            AirTicket ticket = listticket.First(s => s.idticket == idtrip);
            Console.WriteLine("How many tickets do you want to buy ?");
            //get number trip            
            int numbertrip = int.Parse(Console.ReadLine());
            List<Passenger> persons = new List<Passenger>(numbertrip);
            for (int i =0; i < numbertrip; i++)
            {
                Passenger passenger = new Passenger();
                Console.WriteLine("Passenger :" + (i + 1));
                passenger.Input();
                
                passenger.airTicket = ticket;
                persons.Add(passenger);
            }
            persons.ForEach(x => { Console.WriteLine(x); });
            float total = 0;
            foreach(Passenger item in persons)
            {      
                total += item.airTicket.price;
            }           
            Console.Write("Total------->"+ String.Format("{0:0.00}", total));
            Console.ReadKey();           
        }       
    }
         
    
}
