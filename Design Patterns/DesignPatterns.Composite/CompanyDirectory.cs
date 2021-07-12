using System.Collections.Generic;

namespace Design_Patterns
{
    class CompanyDirectory : IEmployee
    {
        private List<IEmployee> _employeeList = new List<IEmployee>();
        public void ShowEmployeeDetails()
        {
            foreach (var employee in _employeeList)
            {
                employee.ShowEmployeeDetails();
            }
        }

        public void AddEmployee(IEmployee employee)
        {
            _employeeList.Add(employee);
        }

        public void RemoveEmployee(IEmployee employee)
        {
            _employeeList.Remove(employee);
        }
    }
}
