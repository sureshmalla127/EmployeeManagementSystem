namespace EmployeeManagement;
abstract class Employee : IPrintable
{
    protected string Name;
    protected int Id;
    protected double BasicSalary;
    protected double NetSalary;

    public Employee(string name,int id, double basicSalary)
    {
        this.Id=id;
        this.Name = name;
        this.BasicSalary = basicSalary;
    }

    public abstract void CalculateSalary();
    public void PrintDetails()
    {
        Console.WriteLine("Employee id :"+Id);
        Console.WriteLine("Name : "+Name);
        Console.WriteLine("Basic Salary : "+BasicSalary);
        Console.WriteLine("Net Salary : "+NetSalary);
    }
}

