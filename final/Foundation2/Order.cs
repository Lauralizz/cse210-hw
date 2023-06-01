using System;

public class Order
{
    private List<Product> products;
    private Customer customer;

    public Order(Customer customer)
    {
        products = new List<Product>();
        this.customer = customer;
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public decimal CalculateTotalCost()
    {
        decimal totalCost = 0;
        foreach (Product product in products)
        {
            totalCost += product.Price * product.Quantity;
        }

        decimal shippingCost = customer.Address.IsInUSA() ? 5 : 35;
        totalCost += shippingCost;

        return totalCost;
    }

    public string GetPackingLabel()
    {
        string packingLabel = "Packing Label:\n";
        foreach (Product product in products)
        {
            packingLabel += $"{product.Name} - {product.ProductId}\n";
        }

        return packingLabel;
    }

    public string GetShippingLabel()
    {
        string shippingLabel = "Shipping Label:\n";
        shippingLabel += $"Customer: {customer.Name}\n";
        shippingLabel += customer.Address.GetFullAddress();

        return shippingLabel;
    }
}