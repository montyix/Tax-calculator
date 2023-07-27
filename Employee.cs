namespace Pro2
{
    public class Employee
    {
        public decimal basepay = 0;
        public String name;

        public Employee(String name, decimal basepay)   
        {
            this.name = name;
            this.basepay = basepay;
        }

        public decimal CalculatePay()
        {
            return basepay;
        }
    }    
}
