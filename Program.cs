namespace EmployeeManagement{
public class Program
{
    public delegate void ManagerDelegate();
    public delegate void ManagerDelegate1();
    public static void Main(string[] args)
    {
        
        Manager manager = new Manager("Suresh",101,10000);
        MarketingExecutive executive = new MarketingExecutive("Pavan",102,20000,100);
        // manager.CalculateSalary();
        // manager.PrintDetails();
        // executive.CalculateSalary();
        // executive.PrintDetails();
        ManagerDelegate m= new ManagerDelegate(manager.CalculateSalary);
                        m+=manager.PrintDetails;
                        m+=executive.CalculateSalary;
                        m+=executive.PrintDetails;
                        m();
    }
}
}
