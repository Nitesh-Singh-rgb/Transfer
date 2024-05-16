using DemoApp.Data;

namespace DemoApp.Models;

public class ShopModel
{
    public List<ProductInfo> ReadProducts()
    {
        using var db = new ShopDbContext();
        var selection = from p in db.Products
                        select new ProductInfo
                        {
                            Productid = p.ProductId,
                            Price = p.Price,
                            stock = p.Stock,
                        };
        
        return [.. selection];
    }


    public List<OrderInfo> ReadOrders()
    {
        using var db = new ShopDbContext();
        var selection = from p in db.Orders
                        select new OrderInfo
                        {
                            orderno = p.Id,
                            customerid = p.CustomerId,
                            productno = p.ProductId,
                            quantity = p.Quantity,
                            Date = p.OrderDate
                        };

        return [.. selection];
    }

    public void WriteProduct(Product entry)
    {
        using var db = new ShopDbContext();
        var product = db.Products.Find(entry.ProductId);
        if (product is null)
        {
            product = new Product {ProductId = entry.ProductId};
            db.Products.Add(product);
        }
        product.Price = entry.Price;
        product.Stock = entry.Stock;
        db.SaveChanges();
    }

    
}