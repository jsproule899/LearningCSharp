using System.Collections;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

class PizzaShop
{
    public static void Main(string[] args)
    {

        List<MenuItem> order1 = new List<MenuItem>();
        order1.Add(new MenuItem("Burger", 4.95));
        Pizza item1 = new Pizza(7);
        item1.addTopping(Topping.Extracheese);
        item1.addTopping(Topping.Onions);
        item1.addTopping(Topping.Peppers);
        item1.addTopping(Topping.Beef);
        order1.Add(item1);
        Pizza item2 = new Pizza(18);
        item2.addTopping(Topping.Extracheese);
        item2.addTopping(Topping.Onions);
        item2.addTopping(Topping.Mushrooms);
        item2.addTopping(Topping.Peppers);
        order1.Add(item2);

        printReceipt(order1);

        List<MenuItem> order2 = ReadOrderFromCSV("OrderList-1-BasicOnly.csv");
        printReceipt(order2);

        List<MenuItem> order3 = ReadOrderFromCSV("OrderList-2-PizzasOnly.csv");
        printReceipt(order3);

        List<MenuItem> order4 = ReadOrderFromCSV("OrderList-3-Full.csv");
        printReceipt(order4);

    }

    public static void printReceipt(List<MenuItem> order)
    {
        double total = 0;
        Console.WriteLine("------------\nOrder Details\n------------");
        foreach (MenuItem item in order)
        {
            if (item is Pizza)
            {
                Pizza? pizza = item as Pizza;
                pizza?.PrintDetails();
            }
            else
            {
                item.PrintDetails();
            }

            total += item.Price;
        }
        Console.WriteLine("-------------------\nTotal Cost: £{0:0.00}\n-------------------", total);
    }

    public static List<MenuItem> ReadOrderFromCSV(string filename)
    {
        List<MenuItem> order = new List<MenuItem>();
        string path = "./Orders/";
        try
        {
            string[] lines = File.ReadAllLines(path + filename);
            foreach (string line in lines)
            {
                string[] lineItem = line.Split(",");
                string name = lineItem[0];
                if (name == "Name") continue;
                double price = double.Parse(lineItem[1]);
                if (name.ToLower() == "pizza")
                {
                    List<Topping> toppings = new List<Topping>();
                    if (lineItem.Length > 2)
                    {
                        for (int i = 2; i < lineItem.Length; i++)
                        {
                            if (lineItem[i] != "")
                            {
                                Topping t = (Topping)Enum.Parse(typeof(Topping), lineItem[i], true);
                                toppings.Add(t);
                            }
                        }
                    }
                    Pizza pizza = new Pizza(name, price, (int)price, toppings);
                    pizza.CalculatePrice();
                    order.Add(pizza);
                }
                else
                {
                    MenuItem menuItem = new MenuItem(name, price);
                    order.Add(menuItem);
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Error reading order from CSV \"{0}\", check file and try again.", filename);
            Console.WriteLine(e.Message);
        }
        return order;
    }
}