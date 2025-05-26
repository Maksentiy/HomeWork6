namespace HomeWork6;

internal class Program
{
    static void Main(string[] args)
    {
        EmployeeRegistry employeeRegistry = Initiate();

        bool loop = true;

        do 
        {
            Console.WriteLine("Press 1 to add new employee");
            Console.WriteLine("Press 2 to show list of employees");
            Console.WriteLine("Press 3 to start search");
            Console.WriteLine("Press 4 to stop program");


            string option = Console.ReadLine();

            switch (option) 
            {
                case "1": 
                    {
                        Console.Clear();
                        NewEmployee(employeeRegistry);
                        break;
                    }
                case "2":
                    {
                        Console.Clear();
                        employeeRegistry.ListAllEmployees();
                        break;
                    }
                case "3": 
                    {
                        Console.Clear();
                        Console.WriteLine("Enter employee name");
                        employeeRegistry.FindEmployee(Console.ReadLine());
                        break;
                    }
                case "4": 
                    {
                        loop = false;
                        break;
                    }
                default: 
                    {
                        Console.WriteLine("Incorrect input, please try again");
                        break;
                    }
            }

            Console.ReadLine();
            Console.Clear();

        } while (loop);
    }


    public static EmployeeRegistry Initiate() 
    {
        EmployeeBase employee1 = new Manager("Alice", 10, 50000, "Workshop", 30);
        EmployeeBase employee2 = new Manager("Kira", 8, 45000, "Database", 70);
        EmployeeBase employee3 = new Worker("Alex", "Economist", "Minsk", 20000);
        EmployeeBase employee4 = new Worker("Max", "Coder", "Grodno", 35000);
        EmployeeBase employee5 = new Worker("Carlos", "Tester", "Brest", 30000);

        EmployeeRegistry employeeRegistry = new EmployeeRegistry();

        employeeRegistry.AddEmployee(employee1);
        employeeRegistry.AddEmployee(employee2);
        employeeRegistry.AddEmployee(employee3);
        employeeRegistry.AddEmployee(employee4);
        employeeRegistry.AddEmployee(employee5);

        return employeeRegistry;
    }

    public static EmployeeRegistry NewEmployee(EmployeeRegistry employeeRegistry) 
    {
        Console.WriteLine("Press 1 to add Manager");
        Console.WriteLine("Press 2 to add Worker");

        switch (Console.ReadLine())
        {
            case "1":
                {
                    Manager manager = new Manager();
                    employeeRegistry.AddEmployee(manager);
                    break;
                }
            case "2":
                {
                    Worker worker = new Worker();
                    employeeRegistry.AddEmployee(worker);
                    break;
                }
            default:
                {
                    Console.WriteLine("Incorrect Input");
                    break;
                }
        }

        return employeeRegistry;
    }
}
