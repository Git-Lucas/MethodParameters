using MethodParameters;

Product myProduct = new(balance: 0, name: "Lucas1");
Product.ChangeProductByReference(ref myProduct);
Console.WriteLine(myProduct); //Balance: 99999 | Name: changed

myProduct = new(balance: 0, name: "Lucas2");
Product.ChangeProductByValue(myProduct);
Console.WriteLine(myProduct); //Balance: 0 | Name: Lucas2

List<Product> products = new()
{
    new(balance: 0, name: "Lucas3"),
    new(balance: 0, name: "Lucas4"),
};
Product.ChangeListProductByReference(ref products);
products.ForEach(x => Console.WriteLine(x)); //ALL: Balance: 99999 | Name: changed

products = new()
{
    new(balance: 0, name: "Lucas5"),
    new(balance: 0, name: "Lucas6"),
};
Product.ClearListProductByValue(products);
if (!products.Any())
{
    Console.WriteLine("Empty!"); //Empty!
}; 