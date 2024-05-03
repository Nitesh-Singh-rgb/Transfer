namespace Loanlib;

public sealed class PersonalLoan : Loan, Taxable
{
    public PersonalLoan(double principle, float period): base(principle, period)
    {}

    public override float GetRate()
    {
        return base.Principle < 500000 ? 15 : 16;
    }

    public double GetTax()
    {
        return GetEMI() * 0.18;
    }
}