
namespace DemoApp;

using Shopping.Mall;

public class Program
{
    public static void Main(string[] args)
    {
        ShoppingCart shoppingCart= new ShoppingCart();
        Item item = new Item(101, 12000, 50);
        Item item1 = new Item(102, 12000, 6);
        shoppingCart.AddItem(item);
        shoppingCart.AddItem(item1);
        System.Console.WriteLine($"Item1 ID[{item.Id}]: ₹{item.SellingPrice()} \nItem2 ID[{item1.Id}]: ₹{item1.SellingPrice()}");
        System.Console.WriteLine("Total Price: ₹{0}", shoppingCart.CartPrice());
        
    }
}