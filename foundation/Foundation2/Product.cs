public class Product
{
    private string _name;
    private string _id;
    private float _itemPrice;
    private float _totalPrice;
    private int _quantity;
 
    public Product(string name, string id, float itemPrice, int quantity)
    {
        _name = name;
        _id = id;
        _itemPrice = itemPrice;
        _quantity = quantity;
        _totalPrice = CalculateTotalPrice();
    }
 
    public string GetName() => _name;
    public void SetName(string name) => _name = name;
 
    public float GetPrice() => _itemPrice;
    public void SetPrice(float price) => _itemPrice = price;
 
    public int GetQuantity() => _quantity;
    public void SetQuantity(int quantity) => _quantity = quantity;
 
    public string GetID() => _id;
    public void SetID(string id) => _id = id;
 
    public float CalculateTotalPrice()
    {
        _totalPrice = _itemPrice * _quantity;
        return _totalPrice;
    }
}