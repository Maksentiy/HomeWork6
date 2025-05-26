namespace HomeWork6;

internal class Worker : EmployeeBase
{
    public string Address { get; set; }

    public int Salary { get; set; }

    public Worker() 
    {
        Console.WriteLine("Input worker name");
        Name = Console.ReadLine();

        Console.WriteLine("Input worker position");
        Position = Console.ReadLine();

        Console.WriteLine("Input worker address");
        Address = Console.ReadLine();

        Console.WriteLine("Input worker salary");
        Salary = Parsing();
    }

    public Worker(string name, string workPosition, string address, int salary)
    {
        Name = name;
        Position = workPosition;
        Address = address;
        Salary = salary;
    }

    public override void GetDetails()
    {
        Console.WriteLine($"Name: {Name}\tPosition: {Position}\tAddress: {Address}\tSalary: {Salary}");
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
                Console.WriteLine("Expecting numeric input, please, repeat last input");
            }
        } while (true);
    }
}
