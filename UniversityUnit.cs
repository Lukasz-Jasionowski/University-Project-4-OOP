using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO_Projekt
{
    internal class UniversityUnit : IInfo
    {
        List<Lecturer> lecturers = new List<Lecturer>();
        private string name = "";
        private string address = "";
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public UniversityUnit(string name, string address)
        {
            this.name = name;
            this.address = address;
        }
        public void AddLecturer(Lecturer lecturer)
        {
            lecturers.Add(lecturer);
        }
        public bool DeleteLecturer(Lecturer lecturer)
        {
            if (lecturers.Contains(lecturer))
            {
                lecturers.Remove(lecturer);
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool DeleteLecturer(string firstName, string lastName)
        {
            foreach (Lecturer l in lecturers)
            {
                if (l.FirstName.Contains(firstName) && l.LastName.Contains(lastName))
                {
                    lecturers.Remove(l);
                    return true;
                }

            }
            return false;
        }
        public void LecturersInfo()
        {
            {
                foreach (Lecturer lecturer in lecturers)

                    lecturer.ShowInfo();
            }
        }
        public void ShowInfo()
        {
            Console.WriteLine("Nazwa: " + name + "\nAdres: " + address);
        }
    }
}