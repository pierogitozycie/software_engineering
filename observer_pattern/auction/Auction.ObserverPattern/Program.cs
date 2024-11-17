using System;

namespace Auction.ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Auction kwiatek = new Auction("Kwiatek", 35);
            Auction lampa = new Auction("Lampa", 150);

            Customer Zosia = new Customer("Zosia");
            Customer Kasia = new Customer("Kasia");

            kwiatek.Attach(Zosia);
            lampa.Attach(Zosia);

            kwiatek.Attach(Kasia);
            lampa.Price = 149;
            kwiatek.Price = 31;

        }
    }
}
