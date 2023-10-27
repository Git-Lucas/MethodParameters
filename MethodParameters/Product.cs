namespace MethodParameters;

public class Product
{
    public int Balance { get; set; }
    public string Name { get; set; }

    public Product(int balance, string name)
    {
        Balance = balance;
        Name = name;
    }

    public static void ChangeProductByReference(ref Product product)
    {
        product = new Product(balance: 99999, name: "changed");
    }

    public static void ChangeProductByValue(Product product)
    {
        product = new Product(balance: 99999, name: "changed");
    }

    public static void ChangeListProductByReference(ref List<Product> products)
    {
        foreach (Product product in products)
        {
            product.Balance = 99999;
            product.Name = "changed";
        }
    }

    public static void ClearListProductByValue(List<Product> products)
    {
        products.Clear();
    }

    public override string ToString()
    {
        return $"Balance: {Balance} | Name: {Name}";
    }
}
