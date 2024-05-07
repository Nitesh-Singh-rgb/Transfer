using System.Reflection;

namespace DemoApp;

class Program
{
    static void Main(string[] args)
    {
        int days = int.Parse(args[0]);
        int noPerson = int.Parse(args[1]);
        Type t = Type.GetType($"MetTours.{args[2]}",true);
        object obj = Activator.CreateInstance(t);
        string te = null;
        if(args[2] == "PremuimTours")
        {
            te = string.Format($"GetDaysRentFor{args[3]}");
        }
        if(args[2] == "EconomyTours")
        {
            te = string.Format(args[3]);
        }
        // MethodInfo scheme = t.GetMethod($"GetDaysRentFor{args[3]}");
        MethodInfo scheme = t.GetMethod(te);
        double charge = (double)scheme.Invoke(obj, [days, noPerson]);   
        System.Console.WriteLine("{0}", charge);

    }
}
