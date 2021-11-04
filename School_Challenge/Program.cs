using System;

namespace School
{
    class Program
    {
        static void Main(string[] args)
        {   
            
            Console.WriteLine("The totla number of Students");
            Student student_1 = new Student(ref School.students);
            Student student_2 = new Student(ref School.students);
            Student student_3 = new Student(ref School.students);
            Student student_4 = new Student(ref School.students);
            Console.WriteLine(School.getStudents());

            
            Console.WriteLine("The totla number of Teachers");
            Teacher teacher_1 = new Teacher(ref School.employees);
            Teacher teacher_2 = new Teacher(ref School.employees);
            Teacher teacher_3 = new Teacher(ref School.employees);
            Teacher teacher_4 = new Teacher(ref School.employees);
            Console.WriteLine(School.getTeachers());

            
            Console.WriteLine("The totla number of Janitors");
            Janitor janitor_1 = new Janitor(ref School.employees);
            Janitor janitor_2 = new Janitor(ref School.employees);
            Janitor janitor_3 = new Janitor(ref School.employees);
            Janitor janitor_4 = new Janitor(ref School.employees);
            Console.WriteLine(School.getJanitors());

            Console.WriteLine("Total number of employees");
            Console.WriteLine(School.getEmployees());
        }
    }
}
