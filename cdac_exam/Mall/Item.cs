namespace Shopping.Mall;

public class Item
{
    public int Id { get;}
    public float CostPerUnit { get; set;}
    public int Qty { get; set;}

    public Item(int id, float costPerUnit,int qty)
    {
        Id = id;
        CostPerUnit = costPerUnit;
        Qty = qty;
    }

    public float SellingPrice()
    {
        return CostPerUnit * Qty;
    }
}