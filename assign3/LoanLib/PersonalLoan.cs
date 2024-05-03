namespace Loanlib;

public sealed class PersonalLoan : Loan, Taxable
{
    private double lowerlimit;
    private double upperlimit;
    public PersonalLoan(double principle, float period, double lowerlimit, double upperlimit): base(principle, period)
    {
        this.lowerlimit = lowerlimit;
        this.upperlimit = upperlimit;
    }

    public override float GetRate()
    {
        float rate = base.Principle < 500000 ? 15 : 16;
        if (Principle < lowerlimit)
        {
            return rate ++;
        }
        if (Principle > upperlimit){
            return rate += 2;
        }
        return rate;
    }

    public double GetTax()
    {
        return GetEMI() * 0.1;
    }
}