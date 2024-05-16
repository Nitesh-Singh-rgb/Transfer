using DemoApp.Data;
using DemoApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace DemoApp.Controllers;

public class HomeController(ShopModel shop) : Controller
{
    public IActionResult Index()
    {
        var products = new CommonModel
        {
            productInfo = shop.ReadProducts(),
            orderInfo = shop.ReadOrders()
        };
        return  View( products) ;
    }


    [HttpPost]

    public IActionResult Register(int id, decimal Price, int stock)
    {
        var product = new Product{ ProductId = id, Price = Price, Stock = stock };
        shop.WriteProduct( product );
        return RedirectToAction("Index");
    }
}