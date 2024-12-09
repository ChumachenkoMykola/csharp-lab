using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // class declaration
    public class Person
    {
        public readonly static Person NewlyBornChild = new Person("", "") { BirthDate = DateTime.Today };
        // constructors
        public Person()
        {

        }
        public Person(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        // properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string EmailAddress { get; set; }
        public int? Height { get; set; }
        public Person Partner { get; set; }


        // method
        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }

        public int GetAge()
        {
            return DateTime.Now.Year - this.BirthDate.Year;
        }

        public bool IsAdult()
        {
            return this.GetAge() > 18;
        }
        Animal Pet = new Animal();
        public void AdoptAPet(Animal pet)
        {
            Pet = pet;
        }



        Apperance apperance = new Apperance();
        public string EyesColor()
        {
            return apperance.EyesColor;
        }
        public string HairColor()
        {
            return apperance.HairColor;
        }
        public bool HasFreckles()
        {
            return apperance.HasFreckles;
        }
    }
}