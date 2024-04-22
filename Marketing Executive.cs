namespace EmployeeManagement;
class MarketingExecutive : Employee
{
    private double KilometerTravel;
    private double TourAllowances;
    private double TelephoneAllowances;

    public MarketingExecutive(string name,int id, double basicSalary, double kilometerTravel) : base(name,id,basicSalary)
    {
        this.KilometerTravel = kilometerTravel;
    }

    public override void CalculateSalary()
    {
        TourAllowances = 5 * KilometerTravel;
        TelephoneAllowances = 1000;

        NetSalary = BasicSalary + TourAllowances + TelephoneAllowances;
    }
    // public void PrintDetails()
    // {
    //     Console.WriteLine("Employee id :"+Id);
    //     Console.WriteLine("Name: "+Name);
    //     Console.WriteLine("Basic Salary: "+BasicSalary);
    //     Console.WriteLine("Net Salary: "+NetSalary);
    // }
}
