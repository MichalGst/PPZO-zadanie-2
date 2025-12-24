using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Runtime.CompilerServices;


public class Pet
{
    // Atrybuty klasy
    public string Name;
    public double Fun;
    public double Hunger;
    public double Energy;

    // Konstruktor inicjalizujący atrybuty
    public Pet(string name, double fun, double hunger, double energy)
    {
        Name = name;
        Fun = fun;
        Hunger = hunger;
        Energy = energy;
    }
}

public class Food
{
   
    public double Nutrition;

    public Food( double nutrition)
    {
        Nutrition = nutrition;
    }
}

public class Toy
{
    public double Fun;
    public double EnergyDrain;

    public Toy( double fun, double energy)
    {
        Fun = fun;
        EnergyDrain = energy;
    }
}

public class Status
{
    public double Energy;
    public double Fun;
    public double Hunger;

    public Status(double energy, double fun, double hunger)
    {
        Energy = energy;
        Fun = fun;
        Hunger = hunger;
    }
    public void statystyki()
    {
        if (Energy > 100) { Energy = 100; }
        if (Energy < 0) { Energy = 0; }
        if (Fun > 100) { Fun = 100; }
        if (Fun < 0) { Fun = 0; }
        if (Hunger < 0) { Hunger = 0; }
        Console.WriteLine("Energia: " + Energy + "/100\n" + "Zabawa: " + Fun + "/100\n" + "Głód: " + Hunger + "/100\n");
    }

}


class Program
{

    static void Main()
    {
        //zmienne do wykorzystania menu
        int start = 1;
        int menu = 0;
        //Tworzenie obiektów
        Pet Dog = new Pet("Azor", 50, 10, 100);
        Food karma = new Food(100);
        Toy Pilka = new Toy(50, 40);
        //Przekazanie Atrybutow Azora do klasy Status
        Status ZdrowieAzor = new Status(Dog.Energy, Dog.Fun, Dog.Hunger);
        //Wywolanie metody klasy Status
        ZdrowieAzor.statystyki();

        //Menu kontroli programu
        while (start == 1)
        {
            Console.WriteLine("1.Karmienie\n2.Zabawa\n3.Statystyki\n4.Wyjscie");
            menu = Convert.ToInt32(Console.ReadLine());
            //Zmiana statystyk po każdej interakcji symuluje upływ czasu.
            if (menu == 1)
            {
                Console.WriteLine("Pies zjadl karme\n");
                ZdrowieAzor.Hunger = ZdrowieAzor.Hunger - karma.Nutrition;
                ZdrowieAzor.Fun = ZdrowieAzor.Fun - 10;
                ZdrowieAzor.Energy = ZdrowieAzor.Energy + 50;
            }

            else if (menu == 2)
            {
                if (ZdrowieAzor.Energy >0 )
                {
                    Console.WriteLine("Pobawiles sie z psem pilka\n");
                    ZdrowieAzor.Hunger = ZdrowieAzor.Hunger + 20;
                    ZdrowieAzor.Fun = ZdrowieAzor.Fun + Pilka.Fun;
                    ZdrowieAzor.Energy = ZdrowieAzor.Energy - Pilka.EnergyDrain;
                }
                else
                {
                    Console.WriteLine("Pies jest zbyt zmęczony.");
                    ZdrowieAzor.Hunger = ZdrowieAzor.Hunger + 10;
                }

            }

            else if (menu == 3)
            {
                ZdrowieAzor.statystyki();
            }

            else if (menu == 4)
            {
                start = 0;
            }

            if (ZdrowieAzor.Hunger >= 100)
            {
                Console.WriteLine("Pies zdechł z głodu :(");
                break;
            }
        }



    }


}