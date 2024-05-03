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


    public static void Main(string[] args)
    {
        double amount = double.Parse(args[0]);
        float time = float.Parse(args[1]);

        Loan[] loan = [new PersonalLoan(amount, time),
                        new PersonalLoan(amount, time)
                        ];

        System.Console.WriteLine("emi {0:0.00}", GetTotalEMI(loan));

    }
}




