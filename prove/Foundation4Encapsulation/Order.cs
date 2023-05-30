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

    public decimal ClaculateTotalCost()
    {

    }
    public string GetPackingLabel()
    {

    }

    public string GetShippingLabel()
    {
    }
}  