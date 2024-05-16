namespace DemoApp.Models;

public readonly record struct OrderInfo(int orderno, DateTime Date, string customerid, int productno, int quantity);