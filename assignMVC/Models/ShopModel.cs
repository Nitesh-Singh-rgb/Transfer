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