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
            Console.Write("You want buy Air Ticket? YES/NO ?");
            string a = Convert.ToString(Console.ReadLine());
            AirTicket newticket = new AirTicket();
            newticket.Print();
            Console.WriteLine("Which idtrip do you want to go");
            int idtrip = int.Parse(Console.ReadLine());
                              
            Console.WriteLine("How many tickets do you want to buy ?");            
            int numbertrip = int.Parse(Console.ReadLine());




            List<Passenger> persons = new List<Passenger>(numbertrip);





            for (int i =0; i < numbertrip; i++)
            {
                Passenger passenger = new Passenger();
                passenger.Print();
                persons.Add(new Passenger {fullname= passenger.fullname, sex = passenger.sex,yearold= passenger.yearold });

            }
            persons.ForEach(x => { Console.WriteLine(x); });
            
        Console.ReadKey();










            /* Console.Write("Enter the number passenger: ");
             int n = int.Parse(Console.ReadLine());
             List<Passenger> persons = new List<Passenger>();
             for (int i = 0; i < n; i++)
             {
                 Passenger passenger = new Passenger();
                 passenger.Print();
                 persons.Add(passenger);

             }*/






        }

        
    }
    class AirTicket
    {   
        public int idticket { get; set; }
        public string nametrip { get; set; } 
        public string dayflight { get; set; } 
        public float price { get; set; } 
        
        public AirTicket(int idticket,string nametrip,string dayflight, float price)
            {
            this.idticket = idticket;
            this.nametrip = nametrip; 
            this.dayflight = dayflight ;
            this.price = price;
            }

        public AirTicket()
        {
        }

        public void Print()
        {
            List<AirTicket> listticket = new List<AirTicket>
            {                   
                new AirTicket {idticket = 1, nametrip ="da nang - ho chi minh", dayflight= "1/12/2020" , price = 10000000.0F},
                new AirTicket {idticket = 2, nametrip ="da nang - ho chi minh", dayflight= "2/12/2020" , price = 15000000.0F},
                new AirTicket {idticket = 3, nametrip ="da nang - ho chi minh", dayflight= "3/12/2020" , price = 30000000.0F},
                new AirTicket {idticket = 4, nametrip ="da nang - ho chi minh", dayflight= "4/12/2020" , price = 20000000.0F},
                new AirTicket {idticket = 5, nametrip ="da nang - ho chi minh", dayflight= "5/12/2020" , price = 50000000.0F}

            };
            Console.WriteLine(" idticket :   nametrip :  day flight :  price ");
            listticket.ForEach(x => { Console.WriteLine(x); });
            /*Console.WriteLine("Name Trip:"+ this.nametrip);
            nametrip = Convert.ToString(Console.ReadLine());    
            Console.WriteLine("Day Flight:"+ this.dayflight);
            dayflight = new DateTime();
            Console.WriteLine("Price:" + this.price);
            price = Console.Read();*/
        }
        public void Show()
        {
            Console.ReadLine();
        }
        public double GetPrice()
        {
            return price;
        }
        public override string ToString()
        {
            return this.idticket + ":" + this.nametrip +":"+ this.dayflight + ":" + String.Format("{0:0.00}", this.price); 
        }

    }
    class Person
    {   
       public string fullname { get; set; }
        public string sex { get; set; }
        public int yearold { get; set; }       
        public Person(string fullname, string sex, int yearold)
        {
            this.fullname = fullname;
            this.sex = sex;
            this.yearold = yearold;           
        }
        ~Person()
        {
            this.fullname = "";
            this.sex = "";
            this.yearold = 0;            
        }
        public Person()
        {
        }

        public void Print()
        {                            
                Console.Write("Full Name: ");
                fullname= Convert.ToString(Console.ReadLine());
                Console.Write("Sex: ");
                sex = Convert.ToString(Console.ReadLine());
                Console.Write("Year Old: ");
                yearold = int.Parse(Console.ReadLine());
                
                  
        }
        public void Show()
        {
            Console.WriteLine("Passenger Name:");
        }    
    }
    class Passenger : Person
    {
        AirTicket ticket = new AirTicket();
        public int amount { get; set; }      
        public Passenger(string fullname,string sex, int yearold,int amount) : base(fullname, sex, yearold)
        {
            this.amount = amount;
        }

        public Passenger()
        {
        }
        public float Total()
        {
            return amount * ticket.price ;
        }
        public override string ToString()
        {
            return this.fullname + ":" + this.sex + ":" + this.yearold ;
        }
    }

    
}
