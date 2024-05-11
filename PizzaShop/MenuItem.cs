using System.Dynamic;

class MenuItem : IDetail
{
    private string _name = "NEW ITEM";
    public string Name
    {
        get { return _name; }
        set
        {
            if (ValidateName(value))
            {
                _name = value;
            }
            else { _name = "INVALID NAME"; }
        }
    }

    private double _price = 0.00;
    public double Price
    {
        get { return _price; }
        set { if (value > 0) _price = value; else _price = 0.00; }
    }


    public MenuItem()
    {
    }
    public MenuItem(string name, double price)
    {
        this.Name = name;
        this.Price = price;

    }

    public void PrintDetails()
    {
        Console.WriteLine("{0}{1} £{2:0.00}", _name, new string(' ', 20 - Name.Length), _price);
    }

    private bool ValidateName(string s)
    {
        string validChars = "abcdefghijklmnopqrstuvwxyz ";

        if (s.Length < 1 || s[0] == ' ')
        {
            return false;
        }

        string lowerCaseString = s.ToLower();
        foreach (char c in lowerCaseString)
        {
            if (!validChars.Contains(c))
            {
                return false;
            }
        }

        return true;
    }

}
