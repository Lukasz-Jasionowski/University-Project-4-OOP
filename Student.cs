using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO_Projekt
{
    internal class Student : Person
    {
        List<FinalAssessment> grades = new List<FinalAssessment>();
        List<Subject> subjects = new List<Subject>();
        private string specialization = "";
        private string specialty = "";
        private int year = 0;
        private int group = 0;
        private int indexNumber = 0;
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
        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        public int Group
        {
            get { return group; }
            set { group = value; }
        }
        public int IndexNumber
        {
            get { return indexNumber; }
            set { indexNumber = value; }
        }
        public Student(string firstName, string lastName, string dateOfBirth, string specialization,
            string specialty, int year, int group, int indexNumber) : base(firstName, lastName, dateOfBirth)
        {
            this.specialization = specialization;
            this.specialty = specialty;
            this.year = year;
            this.group = group;
            this.indexNumber = indexNumber;
        }
        public new void ShowInfo()
        {
            Console.WriteLine("Imię: " + firstName + "\nNazwisko: " + lastName + "\nData urodzenia: " +
                dateOfBirth + "\nKierunek: " + specialization + "\nSpecjalność: " + specialty + "\nRok: " + year +
                "\nGrupa: " + group + "\nNumer Indeksu: " + indexNumber);
        }
        public void GradeInfo()
        {
            foreach (FinalAssessment finalAssessment in grades)
            {
                finalAssessment.ShowInfo();
            }
        }
        public bool AddGrade(string nameOfSubject, double grade, string date, Subject sub)
        {
            grades.Add(new FinalAssessment(grade, date, sub));
            
           return true;
        }
    }
}