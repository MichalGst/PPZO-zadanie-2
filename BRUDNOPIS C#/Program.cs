using System;
using System.Collections.Generic;

public class MenuItem
{
    // Atrybuty klasy: nazwa i cena napoju
    public string Name { get; set; }
    public double Price { get; set; }

    // Konstruktor inicjalizujący atrybuty
    public MenuItem(string name, double price)
    {
        Name = name;
        Price = price;
    }
}

public class Order
{
    // Lista obiektów MenuItem w zamówieniu
    public List<MenuItem> Items { get; private set; }

    // Konstruktor inicjalizuje pustą listę Items
    public Order()
    {
        Items = new List<MenuItem>();
    }

    // Metoda dodaje napój do zamówienia
    public void AddItem(MenuItem item)
    {
        Items.Add(item);
    }

    // Metoda oblicza sumę cen wszystkich napojów w zamówieniu
    public double CalculateTotal()
    {
        double total = 0;
        foreach (var item in Items)
        {
            total += item.Price;
        }
        return total;
    }
}

class Program
{
    static void Main()
    {
        // Tworzenie obiektów MenuItem (różne napoje)
        MenuItem coffee = new MenuItem("Espresso", 5.0);
        MenuItem tea = new MenuItem("Herbata", 4.0);
        MenuItem latte = new MenuItem("Latte", 6.5);

        // Tworzenie obiektu Order i dodawanie napojów
        Order order = new Order();
        order.AddItem(coffee);
        order.AddItem(tea);
        order.AddItem(latte);

        // Obliczanie i wyświetlanie całkowitego kosztu
        double total = order.CalculateTotal();
        Console.WriteLine($"Całkowity koszt zamówienia: {total} zł");
    }
}