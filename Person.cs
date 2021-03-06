using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO_Projekt
{
    internal class Person : IInfo
    {
        protected string firstName = "";
        protected string lastName = "";
        protected string dateOfBirth = "";
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public string DateOfBirth
        {
            get { return dateOfBirth; }
            set { dateOfBirth = value; }
        }
        public Person(string firstName, string lastName, string dateOfBirth)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.dateOfBirth = dateOfBirth;
        }

        public void ShowInfo()
        {
            Console.WriteLine("Imię: " + firstName + "\nNazwisko: " + lastName + "\nData Urodzenia: " + dateOfBirth);
        }
    }
}