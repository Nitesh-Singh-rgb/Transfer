using Loanlib;

public class Program
{
    public static double GetTotalEMI(Loan[] loans)
    {
        double total = 0;
        foreach (Loan loan in loans)
        {
            total += loan.GetEMI();
        }
        return total;
    }

    public static double GetTotalDiscount(Loan[] loans)
    {
        double totalDiscount = 0;
        foreach(Loan loan in loans)
        {
            if (loan is HomeLoan h1)
            {
                h1 = loan as HomeLoan;
                totalDiscount += h1.GetDiscount();
            }
            else
            {
                continue;
            }
        }
        return totalDiscount;
    }
    public static double GetTotalTax(Loan[] loans)
    {
        double totalDiscount = 0;
        foreach(Loan loan in loans)
        {
            if (loan is PersonalLoan h1)
            {
                h1 = loan as PersonalLoan;
                totalDiscount += h1.GetTax();
            }
            else
            {
                continue;
            }
        }
        return totalDiscount;
    }


    public static void Main(string[] args)
    {
        double amount = 40000;//double.Parse(args[0]);
        float time = 2;//float.Parse(args[1]);
        double lower = 1000d;
        double upper = 10000d;
        Loan[] loan = [new PersonalLoan(amount, time, lower, upper),
                        new HomeLoan(amount, time, lower)
                        ];
        System.Console.WriteLine("emi {0:0.00}", GetTotalEMI(loan));
        System.Console.WriteLine("totaldiscount {0:0.00} ", GetTotalDiscount(loan));
        System.Console.WriteLine("totalTax {0:0.00} ", GetTotalTax(loan));
        System.Console.WriteLine("totalTax {0:0.00} ", loan[0].GetEMI());

    }
}




