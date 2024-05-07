import java.lang.reflect.Method;

public class Program {
    public static void main(String[] args) throws Exception{
        int days = Integer.parseInt(args[0]);
        int noPerson = Integer.parseInt(args[1]);
        Class<?> class1 = Class.forName("metTours." + args[2]);
        Object obj = class1.getConstructor().newInstance();
        Method scheme = class1.getMethod("getDaysRent" + args[3],
                                 int.class, int.class);
        double charge = (double)scheme.invoke(obj, days, noPerson);
       // PremiumTours p = new PremiumTours();
        System.out.println("Total Tour Expense: " + charge);
        //System.out.println(p.getDaysRentForWoman(10, 4));
    }
}
