using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO_Projekt
{
    internal class Department
    {
        List<UniversityUnit> universityUnits = new List<UniversityUnit>();
        List<Subject> subjects = new List<Subject>();
        List<Student> students = new List<Student>();
        List<Lecturer> lecturers = new List<Lecturer>();
        public void AddUniversityUnit(string name, string address)
        {
            UniversityUnit NewUniversityUnit = new UniversityUnit(name, address);
            universityUnits.Add(NewUniversityUnit);
        }
        public void AddSubject(Subject subject)
        {
            Subject newSubject = new Subject(subject.Name, subject.Specialization, subject.Specialty, subject.Semester,
                subject.NumberOfHours);
            subjects.Add(newSubject);
        }
        public void AddStudent(Student student)
        {
            Student newStudent = new Student(student.FirstName, student.LastName, student.DateOfBirth, student.Specialization,
                student.Specialty, student.Year, student.Group, student.IndexNumber);
            students.Add(newStudent);
        }
        public bool AddLecturer(Lecturer lecturer, string nameOfUniversityUnit)
        {
            foreach (UniversityUnit un in universityUnits)
            {
                if (un.Name.Contains(nameOfUniversityUnit))
                {
                    Lecturer newLecturer = new Lecturer(lecturer.FirstName, lecturer.LastName, lecturer.DateOfBirth,
                                    lecturer.Position, lecturer.AcademicTitle);
                    lecturers.Add(newLecturer);
                    return true;
                }
            }
            return false;
        }
    }
}