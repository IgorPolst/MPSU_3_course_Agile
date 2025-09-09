using System.ComponentModel.DataAnnotations;
using System.Reflection;
using laba_2;
namespace laba_2;

class Department
{
    public string Name { get; init; }
    public string Managment { get; init; }

    public Department(string name, string managment)
    {
        Name = name;
        Managment = managment;
        employees = new Employee[MaxDepartmentSize];
        employeeCount = 0;
    }

    public void AddEmployee(Employee employee)
    {
        if (employeeCount < employees.Length)
            employees[employeeCount++] = employee;
        else
            throw new InvalidOperationException(DepartmentIsFullError);
    }

    public void RemoveEmployee(Employee employee)
    {
        var index = Array.IndexOf(employees, employee);
        if (index < 0) return;
        for (var i = index + 1; i < employeeCount; i++)
            employees[i - 1] = employees[i];
        --employeeCount;
    }

    public int GetEmployeeCount()
    {
        return employeeCount;
    }

    public Employee GetEmployee(int index)
    {
        if (index < employeeCount)
            return employees[index];
        else
            throw new InvalidOperationException(EmployeeNotExistsError);
    }

    public string GetDepartmentDiscription()
    {
        string result = $"Название отдела: {Name}\n";
        result += $"Руководитель отдела: {Managment}\n\n";
        result += $"Работники отдела:\n";
        for (var i = 0; i < employeeCount; i++)
        {
            result += $"\t{employees[i].ToString()}";
        }

        return result;
    }

    public override string ToString()
    {
        return Name;
    }

    private readonly Employee[] employees;
    private int employeeCount;

    private const int MaxDepartmentSize = 30;
    private const string DepartmentIsFullError = "Отдел заполнен!";
    private const string EmployeeNotExistsError = "Такого сотрудника не существует";
}