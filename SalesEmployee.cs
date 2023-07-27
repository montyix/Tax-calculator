namespace Pro2
{
    public class SalesEmployee : Employee
    {
        private decimal salesbonus = 0;
        public SalesEmployee(String name, decimal basepay, decimal salesbonus) : base(name, basepay)
        {
            this.salesbonus = salesbonus;
        }

        public new decimal CalculatePay()
        {
            return (basepay + salesbonus);
        }
    }
}
