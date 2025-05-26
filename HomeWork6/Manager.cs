namespace HomeWork6;

internal class Manager: EmployeeBase
{
    public int YearsOfExpirience { get; set; }

    public int Salary { get; set; }

    private Project _project { get; set; }

    public Manager() 
    {
        Console.WriteLine("Input Manager name");
        Name = Console.ReadLine();

        Position = "Manager";

        Console.WriteLine("Input Manager Years of Expirience");
        YearsOfExpirience = Parsing();

        Console.WriteLine("Input Manager Salary");
        Salary = Parsing();


        Console.WriteLine("Input Project Name");
        string projectName = Console.ReadLine();

        Console.WriteLine("Input project Deadline");
        int deadline = Parsing();

        _project = new Project(projectName, deadline);
    }

    public Manager(string name, int yearsOfExp, int salary, string projectName, int deadline) 
    {
        Name = name;
        Position = "Manager";
        YearsOfExpirience = yearsOfExp;
        Salary = salary;
        _project = new Project(projectName, deadline);
    }

    public override void GetDetails()
    {
        Console.Write($"Name: {Name}\tPosition: {Position}\tExpirience: {YearsOfExpirience} years\tSalary: {Salary}");
        _project.DisplayProjectInfo();
        
    }

    public class Project
    {
        public string ProjectName { get; set; }

        public int Deadline { get; set; }

        public  Project(string name, int deadline) 
        {
            ProjectName = name;
            Deadline = deadline;
        }

        public void DisplayProjectInfo() 
        {
            Console.WriteLine($" Project name: {ProjectName} Deadline: {Deadline} days");
        }
    }

    public int Parsing()
    {
        do
        {
            string str = Console.ReadLine();
            if (Int32.TryParse(str, out int _))
            {
                return int.Parse(str);
            }
            else
            {
                Console.WriteLine("Incorrect input\n");
                Console.WriteLine("Please, Repeat input");
            }
        } while (true);
    }

}
