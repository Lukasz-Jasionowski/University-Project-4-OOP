using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO_Projekt
{
    internal class Subject : IInfo
    {
        private string name = "";
        private string specialization = "";
        private string specialty = "";
        private int semester = 0;
        private int numberOfHours = 0;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Specialization
        {
            get { return specialization; }
            set { specialization = value; }
        }
        public string Specialty
        {
            get { return specialty; }
            set { specialty = value; }
        }
        public int Semester
        {
            get { return semester; }
            set { semester = value; }
        }
        public int NumberOfHours
        {
            get { return numberOfHours; }
            set { numberOfHours = value; }
        }

        public Subject(string name, string specialization, string specialty, int semester, int numberOfHours)
        {
            this.name = name;
            this.specialization = specialization;
            this.specialty = specialty;
            this.semester = semester;
            this.numberOfHours = numberOfHours;
        }
        public void ShowInfo()
        {
            Console.WriteLine("Nazwa: " + name + "\nKierunek: " + specialization + "\nSpecjalność: " + specialty + "\nSemestr: " + semester + "\nIlość Godzin: " + numberOfHours);
        }
    }
}