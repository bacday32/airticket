using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookAirTicket
{
    class Program
    {
        static void Main(string[] args)
        {

            List<AirTicket> listTicket = new List<AirTicket>
            {
                new AirTicket {idTicket = 1, nameTrip ="da nang - ho chi minh", dayFlight= "1/12/2020" , price = 10000000.0F},
                new AirTicket {idTicket = 2, nameTrip ="da nang - ha noi", dayFlight= "2/12/2020" , price = 15000000.0F},
                new AirTicket {idTicket = 3, nameTrip ="da nang - bangkok", dayFlight= "3/12/2020" , price = 30000000.0F},
                new AirTicket {idTicket = 4, nameTrip ="da nang - london", dayFlight= "4/12/2020" , price = 20000000.0F},
                new AirTicket {idTicket = 5, nameTrip ="da nang - bac kinh", dayFlight= "5/12/2020" , price = 50000000.0F}

            };
            Console.Write("You want buy Air Ticket? YES/NO ?");
            string a = Convert.ToString(Console.ReadLine());
            //show item of listTicket 
            foreach (AirTicket item in listTicket)
            {
                Console.WriteLine(item);
            }
            int idTrip=0;         
            AirTicket ticket = new AirTicket() ;
            do
            {
                try
                {   
                    Console.WriteLine("Which idtrip do you want to go");
                    idTrip = int.Parse(Console.ReadLine());
                    //if idtrip != idTicket ---> catch and return try else break do while                    
                    ticket = listTicket.First(s => s.idTicket == idTrip);
                    break;
                }
                catch(Exception ex)
                {
                    Console.WriteLine("please re-enter!!");
                }
            }
            while (true);       

            Console.WriteLine("How many tickets do you want to buy ?");
            //get number trip            
            int numberTrip = int.Parse(Console.ReadLine());
            List<Passenger> persons = new List<Passenger>(numberTrip);
            for (int i = 0; i < numberTrip; i++)
            {
                Passenger passenger = new Passenger();
                Console.WriteLine("Passenger : " + (i + 1));
                // input infor passenger
                passenger.Input();
                // assigned ticket for airTicket in passenger
                passenger.airTicket = ticket;
                //add object passenger in list persons
                persons.Add(passenger);
            }
            //show list passenger book ticket
            persons.ForEach(x => { Console.WriteLine(x); });
            //for in list get price of airTicket
            float total = 0;
            foreach (Passenger item in persons)
            {
                total += item.airTicket.price;
            }
            Console.Write("Total------->" + String.Format("{0:0.00}", total));
            Console.ReadKey();
        }
        
    }
    


}
