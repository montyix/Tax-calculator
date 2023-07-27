namespace Pro2
{
    class Program
    {
        static void Main(string[] args)
        {
            SalesEmployee employee1 = new SalesEmployee("Billy", 800, 300);
            Employee employee2 = new Employee("Helen", 600);

            Console.WriteLine("Employee#1 " + employee1.name + " earned: " + employee1.CalculatePay().ToString() + "; taxes: " + Tax.CalcTax(employee1).ToString());
            Console.WriteLine("Employee#2 " + employee2.name + " earned: " + employee2.CalculatePay().ToString() + "; taxes: " + Tax.CalcTax(employee2).ToString());
        }
    }
}