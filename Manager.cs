using System;
namespace EmployeeManagement;
class Manager : Employee
{ 
   
    private double PetrolAllowance;
    private double FoodAllowance;
    private double OtherAllowances;

    public Manager(string name,int id, double basicSalary) : base(name,id, basicSalary) { }

    public override void CalculateSalary()
    {
        PetrolAllowance = 0.08 * BasicSalary;
        FoodAllowance = 0.13 * BasicSalary;
        OtherAllowances = 0.03 * BasicSalary;

        NetSalary = BasicSalary + PetrolAllowance + FoodAllowance + OtherAllowances;
    }
    // public void PrintDetails()
    // {
    //     Console.WriteLine("Employee id :"+Id);
    //     Console.WriteLine("Name: "+Name);
    //     Console.WriteLine("Basic Salary: "+BasicSalary);
    //     Console.WriteLine("Net Salary: "+NetSalary);
    // }
}
