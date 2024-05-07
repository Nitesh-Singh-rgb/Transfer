namespace MetTours;

class EconomyTours
{
    public double GetDaysRent(int days, int noPersons)
    {
        return 500 * days * noPersons;
    }
}