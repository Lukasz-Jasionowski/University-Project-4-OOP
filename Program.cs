using System;

namespace PO_Projekt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Department department1 = new Department();
            Department department2 = new Department();
            UniversityUnit universityUnit1 = new UniversityUnit("Toruń", "Piernikowa 23");
            UniversityUnit universityUnit2 = new UniversityUnit("Bydgoszcz", "Targowa 16");
            Person person1 = new Person("Adam", "Sosnowski", "30 Stycznia 1990");
            Person person2 = new Person("Agnieszka", "Brzozowska", "14 Sierpień 1985");
            Student student1 = new Student("Adam", "Sosnowski", "30 Stycznia 1990", "Informatyka", "Programowanie", 3, 2, 1111);
            Student student2 = new Student("Agnieszka", "Brzozowska", "14 Sierpień 1985", "Informatyka", "Gry mobilne", 2, 1, 2222);
            Lecturer lecturer1 = new Lecturer("Michał", "Stokrotka", "10 Grudzień 1960", "Dziekan", "Profesor");
            Lecturer lecturer2 = new Lecturer("Marzena", "Różalska", "1 Czerwca 1973", "Wykładowca", "Magister Inżynier");
            Subject subject1 = new Subject("Programowanie Obiektowe", "Informatyka", "Programowanie", 3, 40);
            Subject subject2 = new Subject("Java", "Informatyka", "Gry mobilne", 2, 60);
            FinalAssessment f1 = new FinalAssessment(5.0, "10 Stycznia 2022", subject1);
            FinalAssessment f2 = new FinalAssessment(4.5, "12 Luty 2022", subject2);

            Console.WriteLine("!! KLASA PERSON !!");
            person1.ShowInfo();
            person2.ShowInfo();

            Console.WriteLine("\n!! KLASA STUDENT !!");
            student1.ShowInfo();
            student1.AddGrade("Programowanie Obiektowe", 5.0, "10 Styczeń 2022", subject1);
            student1.GradeInfo();
            Console.WriteLine();
            student2.ShowInfo();
            student2.AddGrade("Java", 4.5, "12 Luty 2022", subject2);
            student2.GradeInfo();

            Console.WriteLine("\n!! KLASA FINAL ASSESSMENT !!");
            f1.ShowInfo();
            f2.ShowInfo();

            Console.WriteLine("\n!! KLASA SUBJECT !!");
            subject1.ShowInfo();
            subject2.ShowInfo();

            Console.WriteLine("\n!! KLASA LECTURER !!");
            lecturer1.ShowInfo();
            lecturer2.ShowInfo();

            Console.WriteLine("\n!! KLASA UNIVERSITY UNIT!! ");
            universityUnit1.ShowInfo();
            universityUnit1.AddLecturer(lecturer1);
            universityUnit1.LecturersInfo();
            universityUnit1.DeleteLecturer(lecturer1);
            Console.WriteLine("USUWANIE");
            universityUnit1.LecturersInfo();
            Console.WriteLine();
            universityUnit2.ShowInfo();
            universityUnit2.AddLecturer(lecturer2);
            universityUnit2.LecturersInfo();
            universityUnit2.DeleteLecturer("Marzena", "Różalska");
            Console.WriteLine("USUWANIE");
            universityUnit2.LecturersInfo();

            Console.WriteLine("\n!! KLASA DEPARTMENT !!");
            department1.AddUniversityUnit("Toruń", "Piernikowa 23");
            department1.UniverstyUnitInfo(true);
            department1.AddSubject(subject1);
            department1.AddStudent(student1);
            department1.AddLecturer(lecturer1, "Toruń");
            department1.StudentsInfo(true);
            department1.SubjectsInfo();
            department1.AddGrade(1111, "Programowanie Obiektowe", 5, "14 Stycznia 2022", subject1);
            department1.RemoveStudent(1111);
            Console.WriteLine("USUWANIE STUDENTA");
            department1.StudentsInfo(true);
            Console.WriteLine();
            department2.AddUniversityUnit("Bydgoszcz", "Targowa 16");
            department2.UniverstyUnitInfo(true);
            department2.AddSubject(subject2);
            department2.AddStudent(student2);
            department2.AddLecturer(lecturer2, "Bydgoszcz");
            department2.StudentsInfo(true);
            department2.SubjectsInfo();
            department2.AddGrade(2222, "Java", 4, "5 Stycznia 2022", subject2);
            department2.RemoveStudent(2222);
            Console.WriteLine("USUWANIE STUDENTA");
            department2.StudentsInfo(true);
        }
    }
}