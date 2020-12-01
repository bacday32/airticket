using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatVeMayBay
{
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
        public Person()
        {
        }
        public void Input()
        {
            Console.Write("Full Name: ");
            this.fullname = Convert.ToString(Console.ReadLine());
            Console.Write("Sex: ");
            this.sex = Convert.ToString(Console.ReadLine());
            Console.Write("Year Old: ");
            this.yearold = int.Parse(Console.ReadLine());
        }        
    }
}
