using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookAirTicket
{
    class Person
    {
        protected string fullName { get; set; }
        protected string sex { get; set; }
        protected int yearOld { get; set; }
        public Person(string fullName, string sex, int yearOld)
        {
            this.fullName = fullName;
            this.sex = sex;
            this.yearOld = yearOld;
        }
        public Person()
        {
        }
        public void Input()
        {
            Console.Write("Full Name: ");
            this.fullName = Convert.ToString(Console.ReadLine());
            Console.Write("Sex: ");
            this.sex = Convert.ToString(Console.ReadLine());
            Console.Write("Year Old: ");
            this.yearOld = int.Parse(Console.ReadLine());
        }        
    }
}
