namespace HomeWork6;

internal class EmployeeRegistry
{
    List<EmployeeBase> EmployeeList { get; set; }

    public EmployeeRegistry() 
    {
        EmployeeList = new List<EmployeeBase>();
    }

    public void AddEmployee(EmployeeBase employee) 
    {
        EmployeeList.Add(employee);
    }

    public void ListAllEmployees() 
    {
        foreach (EmployeeBase employee in EmployeeList) 
        {
            employee.GetDetails();
        }
    }

    public void FindEmployee(string name) 
    {
        foreach (EmployeeBase employee in EmployeeList) 
        {
            if (employee.Name.ToLower().Trim() == name.ToLower().Trim()) 
            {
                employee.GetDetails();
            }
        }
    }
}
