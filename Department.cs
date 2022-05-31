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
        List<FinalAssessment> finalAssessments = new List<FinalAssessment>();
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
        public void StudentsInfo(bool gradesInfo)
        {
            foreach (Student student in students)
            {
                if (gradesInfo == true)
                {
                    student.ShowInfo();
                    student.GradeInfo();
                }
                else
                {
                    student.ShowInfo();
                }
            }
        }
        public void UniverstyUnitInfo(bool lecturersInfo)
        {
            foreach (UniversityUnit u in universityUnits)
            {
                if (lecturersInfo == true)
                {
                    u.ShowInfo();
                    u.LecturersInfo();
                }
                else
                {
                    u.ShowInfo();
                }
            }
        }
        public void SubjectsInfo()
        {
            foreach (Subject subject in subjects)
            {
                subject.ShowInfo();
            }
        }
        public bool AddGrade(int indexNumber, string nameOfSubject, int grade, string date)
        {
            foreach (Subject s in subjects)
            {
                if (s.Name.Contains(nameOfSubject))
                {
                    foreach (Student st in students)
                    {
                        st.AddGrade(nameOfSubject, grade, date);
                        return true;
                    }
                }
            }
            return false;
        }
        public bool RemoveStudent(int indexNumber)
        {
            foreach (Student s in students)
            {
                if (s.IndexNumber == indexNumber)
                {
                    students.Remove(s);
                    return true;
                }
            }
            return false;
        }
    }
}