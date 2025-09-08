namespace laba_2;

public class Employee
{
    public String Name { get; init; }
    public String Position { get; init; }
    public int Salary { get; set; }

    public Employee(string name, string position, int salary)
    {
        Name = name;
        Position = position;
        Salary = salary;
    }

    public override string ToString()
    {
        return $"ФИО: {Name}, \n Должность: {Position} - {Salary}р.\n";
    }
    
}