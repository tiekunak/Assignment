using System;

namespace School
{
    class Janitor : Employees
    {

        // Constructor
        public Janitor(ref int employees)
        {
            School.janitors++;
            employees++;
            this.EmployeeId = employees;
        }
    }
}