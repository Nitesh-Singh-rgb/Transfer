package metTours;

public class PremiumTours {
    private double DiscountRate(int days, int noPersons){
        double charge = 1200;
        charge = charge -( days > 6 ? 100 : 0);
        charge = charge -(noPersons >= 4 ? 100 : 0);
        return charge;
    }
    public double getDaysRentForCommon(int days, int noPersons){
        return DiscountRate(days, noPersons) * days * noPersons;
    }

    public double getDaysRentForSeniors(int days, int noPersons){
       
       return (DiscountRate(days, noPersons) - 100) * days * noPersons;
    }

    public double getDaysRentForWoman(int days, int noPersons){
        return (DiscountRate(days, noPersons) - 200) * days * noPersons;
    }



    
}
