namespace HomeWork6;

internal static class EmployeeRegistry
{
    private static List<EmployeeBase> _employeeList = new List<EmployeeBase>();

    public static void AddEmployee(EmployeeBase employee) 
    {
        _employeeList.Add(employee);
    }

    public static void ListAllEmployees() 
    {
        foreach (EmployeeBase employee in _employeeList) 
        {
            employee.GetDetails();
        }
    }

    public static void FindEmployee(string name) 
    {
        foreach (EmployeeBase employee in _employeeList) 
        {
            if (employee.Name.ToLower().Trim() == name.ToLower().Trim()) 
            {
                employee.GetDetails();
            }
        }
    }
}
