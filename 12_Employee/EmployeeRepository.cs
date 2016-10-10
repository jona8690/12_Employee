using System;
using System.Collections.Generic;

namespace _12_Employee
{
    internal class EmployeeRepository
    {

        Dictionary<long, Employee> emp = new Dictionary<long, Employee>();

        private static long id = 0;

        internal void Clear()
        {
            emp.Clear();
        }

        internal long CountEmployees()
        {
            return emp.Count;
        }

        internal Employee CreateEmployee(string v1, string v2)
        {
            id++;
            Employee NewEmployee = new Employee();
            NewEmployee.Name = v1;
            NewEmployee.Type = v2;
            NewEmployee.Id = id;
            return NewEmployee;

        }

        internal void SaveEmployee(Employee employee)
        {
            if (emp.ContainsKey(employee.Id))
                emp[employee.Id] = employee;
            else
                emp.Add(employee.Id, employee);
                
        }

        internal Employee LoadEmployee(long id)
        {
            return emp[id];
        }

        internal List<Employee> FindAllEmployees()
        {
            List<Employee> returnList = new List<Employee>();
            foreach (KeyValuePair<long, Employee> entry in emp)
            {
                returnList.Add(entry.Value);

            }
            return returnList;
        }
    }
}