using System.Collections.Generic;

public class ShoppingCart
{
    private Dictionary<Product, int> products = new Dictionary<Product, int>();

    public void AddProduct(Product product, int quantity)
    {
        if (products.ContainsKey(product))
        {
            products[product] += quantity;
        }
        else
        {
            products[product] = quantity;
        }
    }

    public double CalculateTotal()
    {
        double total = 0;
        foreach (var pair in products)
        {
            total += pair.Key.Price * pair.Value;
        }
        return total;
    }
}
