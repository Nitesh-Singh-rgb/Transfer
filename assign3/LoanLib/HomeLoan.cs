namespace Loanlib;

    public sealed class HomeLoan : Loan, Discountable
    {
        private double Limit { get; set; }

        public HomeLoan (double principle, float period, double limit) : base (principle, period)
        {
            Limit = limit;
        }

        public override float GetRate()
        {
            if (base.Principle > Limit)
                return base.Principle < 2000000 ? 11 : 12;
            return base.Principle < 2000000 ? 10 : 11;
        }

        public double GetDiscount()
        {
            return GetEMI() * 0.1;
        }
    }
