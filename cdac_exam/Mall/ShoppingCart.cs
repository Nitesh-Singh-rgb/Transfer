
namespace Shopping.Mall;

public class ShoppingCart
{
    public List<Item> item;

    public ShoppingCart()
    {
        item = new List<Item>();
    }

    public void AddItem(Item item)
    {
        this.item.Add(item);
    }

    public float CartPrice()
    {
        float sum = 0;
        foreach (Item item in item){
            sum += item.SellingPrice();
        }
        if(sum > 50000)
        {
            return sum *(1- 0.05f);
        }
        if(sum > 100000)
        {
            return sum * 0.1f;
        }
        return sum;
    }
}