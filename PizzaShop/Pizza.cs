using System.Collections;
using Microsoft.CSharp.RuntimeBinder;

class Pizza : MenuItem
{
    private int _size;
    public int Size
    {
        get { return _size; }
        set
        {
            if (value <= 8)
            {
                _size = 8;
            }
            else
            {
                _size = 16;
            }

        }
    }
    private List<Topping> _extraToppings { get; set; }

    public Pizza(int size)
    {
        Name = "CYO Pizza";
        Size = size;
        Price = Size;
        _extraToppings = new List<Topping>();
    }

    public Pizza(string name, double price, int size, List<Topping> toppings) : base(name, price)
    {
        Size = size;
        Price = Size;
        _extraToppings = toppings;
    }

    public void addTopping(Topping t)
    {
        if (_extraToppings.Contains(t))
        {
            Console.WriteLine("Pizza already has {0} as a topping", t);
        }
        else
        {
            _extraToppings.Add(t);
            Price += 0.5;
        }
    }

    public new void PrintDetails()
    {
        string leftAlignPrice = new string(' ', 20);
        Console.WriteLine("{0} ({1}\"){2} £{3:0.00}", Name, Size, new string(' ',  15- Name.Length-Size.ToString().Length), Price);
        if (_extraToppings.Count > 0)
            Console.WriteLine(" with toppings:");
        foreach (Topping t in _extraToppings)
        {
            Console.WriteLine("* " + t.ToString());
        }

    }

    public bool IsVegetarian()
    {
        foreach (Topping t in _extraToppings)
        {
            if (t.ToString() == "Pepperoni" || t.ToString() == "Beef" || t.ToString() == "Chicken" || t.ToString() == "Ham")
                return false;
        }
        return true;
    }

    public void CalculatePrice()
    {
        Price += _extraToppings.Count * 0.5;
    }

}