using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO_Projekt
{
    internal class FinalAssessment : IInfo
    {
        public List<Subject> subjects = new List<Subject>();
        private double value = 0.0;
        private string date = "";
        public double Value
        {
            get { return value; }
            set { this.value = value; }
        }
        public string Date
        {
            get { return date; }
            set { date = value; }
        }
        public FinalAssessment(double value, string data, Subject s)
        {
            this.value = value;
            this.date = data;
            subjects.Add(s);
        }
        public void ShowInfo()
        {
            foreach (Subject s in subjects)
            {
                Console.WriteLine("Przedmiot: " + s.Name + "\nOcena: " + value + "\nData wystawienia: " + date);
            }
        }
    }
}