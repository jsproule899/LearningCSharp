using System.Collections;

class Pizza : MenuItem{
    private int _size;
    public int Size{
        get{ return _size;}
        set{ _size = value;}
    }
    private List<Topping> _extraToppings;

    public Pizza(string name, double price, int size, List<Topping> toppings) : base(name, price)
    {
    }

    public void addTopping(Topping t){
        if(_extraToppings.Contains(t))  Console.WriteLine("Pizza already has {0} as a topping", t);
        else _extraToppings.Add(t);
    }

}