namespace Loanlib;

public abstract class Loan
{
    public double Principle { get; set; }
    public float Period { get; set; }

    public Loan(double principle, float period)
    {
        Principle = principle;
        Period = period;
    }

    public abstract float GetRate();

    public double GetEMI()
    {
        return Principle * (1 + GetRate() * Period/100) / (12 * Period);
    }

}
