using System.Text;
 
public class Order
{
    private List<Product> _listProducts;
    private List<Customer> _customer;
    private int _totalPrice;
    private int _shippingCost;
    private string _packingLabel;
    private string _shippingLabel;
 
    public Order(List<Customer> customer)
    {
        _customer = customer;
        _listProducts = new List<Product>();
    }
 
    public void AddProduct(Product product)
    {
        _listProducts.Add(product);
    }
 
    public int CalculateShippingCost()
    {
        _shippingCost = _customer[0].CustomerInUSA() ? 5 : 35;
        return _shippingCost;
    }
 
    public int CalculateTotalPrice()
    {
        _totalPrice = 0;
        foreach (var product in _listProducts)
        {
            _totalPrice += (int)product.CalculateTotalPrice();
        }
        _totalPrice += CalculateShippingCost();
        return _totalPrice;
    }
 
    public string GetPackingLabel()
    {
        StringBuilder packingLabel = new StringBuilder();
        foreach (var product in _listProducts)
        {
            packingLabel.AppendLine($"{product.GetName()} (ID: {product.GetID()})");
        }
        _packingLabel = packingLabel.ToString();
        return _packingLabel;
    }
 
    public string GetShippingLabel()
    {
        var customer = _customer[0];
        _shippingLabel = $"{customer.GetName()}\n{customer.GetAddress().DisplayFullAddress()}";
        return _shippingLabel;
    }
}