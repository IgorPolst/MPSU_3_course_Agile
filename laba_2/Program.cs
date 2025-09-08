namespace laba_2;


class Program
{
    static void Main(string[] args)
    {
        Employee emp1 = new Employee("Иван Иванов", "Менеджер", 50000);
        Employee emp2 = new Employee("Мария Петрова", "Бухгалтер", 45000);
        Employee emp3 = new Employee("Алексей Смирнов", "Программист", 70000);
        Employee emp4 = new Employee("Ольга Кузнецова", "Аналитик", 60000);
        Employee emp5 = new Employee("Дмитрий Орлов", "Тестировщик", 48000);

        Department dep1 = new Department("Отдел разработки", "Князева Мария");
        dep1.AddEmployee(emp1);
        dep1.AddEmployee(emp2);
        dep1.AddEmployee(emp3);

        Department dep2 = new Department("Отдел продаж", "Горшнёва Виктория");
        dep2.AddEmployee(emp4);
        dep2.AddEmployee(emp5);

        Company com1 = new Company("Вечная лоза", "Музыкальные инструменты");
        com1.AddDepartment(dep1);
        com1.AddDepartment(dep2);

        Console.WriteLine(com1.GetCompanyDescription());
        Console.WriteLine($"Общее количество сотрудников: {com1.CountEmployees}\n");

        Console.WriteLine(dep1.GetDepartmentDiscription());
        Console.WriteLine(emp1);


    }
}