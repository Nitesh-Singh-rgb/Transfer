using System.Reflection;

namespace DemoApp;

delegate double DaysRent(int days, int noPerson);
class Program
{
    static void Main(string[] args)
    {
        int days = int.Parse(args[0]);
        int noPerson = int.Parse(args[1]);
        Type t = Type.GetType($"MetTours.{args[2]}",true);
        object obj = Activator.CreateInstance(t);
        string te = null;
        if(t.Name == "PremiumTours") 
        {
            te = $"GetDaysRentFor{args[3]}";
        }
        if(t.Name == "EconomyTours")
        {
            te = args[3];
        }
        // MethodInfo scheme = t.GetMethod($"GetDaysRentFor{args[3]}");
        MethodInfo scheme = t.GetMethod(te);
        var dr = scheme.CreateDelegate<DaysRent>(obj);
        double charge = dr(days, noPerson);   
        System.Console.WriteLine("{0}", charge);

    }
}
