public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    // This is the constructor of the Address class, you could use the primary constructor, removing the constructor and placing the parameters in the main Address class. I decided to use the constructor shown in the learning activities
    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    // In this method, I convert _country to lowercase and compare it with the string "usa".
    public bool IsInUSA()
    {
        return _country.ToLower() == "usa";
    }
    // In this method, I return a string containing the _street, _city, _state, and _country variables.
    public string GetFullAddress()
    {
        return $"{_street}\n{_city}, {_state}\n{_country}";
    }
}
