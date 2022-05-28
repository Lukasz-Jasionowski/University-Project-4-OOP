using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO_Projekt
{
    internal class Lecturer : Person
    {
        private string academicTitle = "";
        private string position = "";
        public string AcademicTitle
        {
            get { return academicTitle; }
            set { academicTitle = value; }
        }
        public string Position
        {
            get { return position; }
            set { position = value; }
        }
        public Lecturer(string firstName, string lastName, string dateOfBirth, string position, string academicTitle) : base(firstName, lastName, dateOfBirth)
        {
            this.position = position;
            this.academicTitle = academicTitle;
        }
        public new void ShowInfo()
        {
            Console.WriteLine("Imię: " + firstName + "\nNazwisko: " + lastName + "\nData Urodzenia: " + dateOfBirth +
                "\nTytuł Naukowy: " + academicTitle + "\nStanowisko: " + position);
        }
    }
}