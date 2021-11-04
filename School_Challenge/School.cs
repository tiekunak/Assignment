using System;

namespace School
{
    class School
    {
        public static int students;

        public static int janitors;

        public static int teachers;

        public static int employees;


        // Constructor
        public School()
        {
            students = 0;
            teachers = 0;
            janitors = 0;
            employees = 0;
        }

        // Method
        public static int getStudents()
        {
            return students;
        }


        // Method
        public static int getTeachers()
        {
            return teachers;
        }      

        // Method
        public static int getJanitors()
        {
            return janitors;
        }

        // Method
        public static int getEmployees()
        {
            return employees;
        }
    }
}
