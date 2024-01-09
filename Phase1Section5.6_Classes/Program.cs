using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phase1Section5._6_Classes
{

    public class Program
    {
        static void Main(string[] args)
        {
            runApp();
        }

        public static void runApp()
        {

            string[] arrSubjects = { "English Literature", "English Language", "Maths", "Geography", "History", "Physics", "Chemistry", "Biology" };
            string[] arrSubjectShorts = { "ELIT", "ELANG", "MATH", "GEOG", "HIST", "PHY", "CHEM", "BIO" };


            string[] arrStudents = { "Rahul Gandhi", "Vijay Mallya", "Lady Gaga", "Arun Jaitley", "MS Dhoni", "Kim Kardashian" };
            List<Student> listStudents = new List<Student>();
            List<Subject> listSubjects = new List<Subject>();

            for (int i = 0; i < arrSubjects.Length; i++)
            {
                Subject subject = new Subject();
                subject.Name = arrSubjects[i];
                subject.ShortName = arrSubjectShorts[i];
                listSubjects.Add(subject);
            }

            for (int i = 0; i < arrStudents.Length; i++)
            {
                Student student = new Student();
                student.Name = arrStudents[i];
                student.Address = "Some address";
                student.ContactNumber = "124567";
                student.GuardianName = "My Guardian";
                listStudents.Add(student);
            }

            Teacher classTeacher = new Teacher();
            classTeacher.Name = "Mr.RadheShyam";
            classTeacher.DateOfJoining = Convert.ToDateTime("2010-09-11 00:00:00");
            classTeacher.ContactAddress = "Some address";

            CClass class1A = new CClass();
            Subject s= new Subject();
            Student s1 = new Student();
            Teacher teacher = new Teacher();
            class1A.Name = "1A";
            s1.Students = listStudents;
            s.Subjects = listSubjects;
            teacher.ClassTeacher = classTeacher;

            
               
            Console.WriteLine($"Class Name: {class1A.Name}");
            Console.WriteLine($"Class Teacher: {teacher.ClassTeacher.Name}");
            Console.WriteLine($"Class Teacher's Joining Date: {teacher.ClassTeacher.DateOfJoining}");

               
            Console.WriteLine("\nStudents:");
            foreach (var student in s1.Students)
            {
                 Console.WriteLine($"Name: {student.Name,10}, Address: {student.Address}, Contact Number: {student.ContactNumber}, Guardian Name: {student.GuardianName}");
            }
                Console.WriteLine("\nSubjects:");
                foreach (var subject in s.Subjects)
                {
                    Console.WriteLine($"Name: {subject.Name,-20} Short Name: {subject.ShortName}");
                }
        }
    }
}


