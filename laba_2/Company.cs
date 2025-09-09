using System.Collections;
using System.ComponentModel;

namespace laba_2;

class Company
{
    public string Name { get; init; }
    public string Industry { get; init; }
    public int CountEmployees => CalculateEmployees();
    public IEnumerable<Department> Departments => departments;

    public Company(string name, string industry)
    {
        Name = name;
        Industry = industry;
        departments = new List<Department>();
    }

    public void AddDepartment(Department department)
    {
        departments.Add(department);
    }

    public void RemoveDepartment(Department department)
    {
        if (departments.IndexOf(department) < 0) return;
        else departments.Remove(department);
    }

    public string GetCompanyDescription()
    {
        string res = $"Название компании: {Name}\nОтрасль: {Industry}\n";
        res += "Подразделения: \n";

        for (var i = 0; i < departments.Count; i++)
        {
            res += $"\t{departments[i].ToString()}\n";
        }

        return res;
    }

    public override string ToString()
    {
        return Name;
    }

    private int CalculateEmployees()
    {
        int res = 0;
        for (var i = 0; i < departments.Count; i++)
        {
            res += departments[i].GetEmployeeCount();
        }

        return res;
    }

    private readonly List<Department> departments;
}