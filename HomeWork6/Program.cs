namespace HomeWork6;

internal class Program
{
    static void Main(string[] args)
    {
        Initiate();

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
                        NewEmployee();
                        break;
                    }
                case "2":
                    {
                        Console.Clear();
                        EmployeeRegistry.ListAllEmployees();
                        break;
                    }
                case "3": 
                    {
                        Console.Clear();
                        Console.WriteLine("Enter employee name");
                        EmployeeRegistry.FindEmployee(Console.ReadLine());
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


    public static void Initiate() 
    {
        EmployeeBase employee1 = new Manager("Alice", 10, 50000, "Workshop", "March");
        EmployeeBase employee2 = new Manager("Kira", 8, 45000, "Database", "May");
        EmployeeBase employee3 = new Worker("Alex", "Economist", "Minsk", 20000);
        EmployeeBase employee4 = new Worker("Max", "Coder", "Grodno", 35000);
        EmployeeBase employee5 = new Worker("Carlos", "Tester", "Brest", 30000);

        EmployeeRegistry.AddEmployee(employee1);
        EmployeeRegistry.AddEmployee(employee2);
        EmployeeRegistry.AddEmployee(employee3);
        EmployeeRegistry.AddEmployee(employee4);
        EmployeeRegistry.AddEmployee(employee5);
    }

    public static void NewEmployee() 
    {
        Console.WriteLine("Press 1 to add Manager");
        Console.WriteLine("Press 2 to add Worker");

        switch (Console.ReadLine())
        {
            case "1":
                {
                    Manager manager = new Manager();
                    EmployeeRegistry.AddEmployee(manager);
                    break;
                }
            case "2":
                {
                    Worker worker = new Worker();
                    EmployeeRegistry.AddEmployee(worker);
                    break;
                }
            default:
                {
                    Console.WriteLine("Incorrect Input");
                    break;
                }
        }
    }
}
