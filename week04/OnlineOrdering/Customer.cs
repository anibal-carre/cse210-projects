public class Customer(string name, Address address)
{
    private string _name = name;
    private Address _address = address;

    public bool LivesInUSA()
    {
        return _address.IsInUSA();
    }

    public string GetName()
    {
        return _name;
    }

    public string GetAddress()
    {
        return _address.GetFullAddress();
    }
}