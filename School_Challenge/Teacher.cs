using System;

namespace School
{
    class Teacher : Employees
    {

        // Constructor
        public Teacher(ref int employees)
        {
            School.teachers++;
            employees++;
            this.EmployeeId = employees;
        }
    }
}