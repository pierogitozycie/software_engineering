using System;

namespace Auction.ObserverPattern
{
    // Obserwator
    public class Customer : IObserver
    {
        private string _name;

        public Customer(string name)
        {
            this._name = name;
        }

        // Aktualizacja w wersji "PULL" - wyciąganie danych
        public void Update(Auction auction)
        {
            string name = auction.Name;
            int price = auction.Price;

            Console.WriteLine("-------------");
            Console.WriteLine("Powiadomienie dla użytkownika: {0}", this._name);
            Console.WriteLine("Auckja: {0} zmieniła cenę na: {1}", name, price);
        }

        // Aktualizacja w wersji "PUSH"
        // public void Update(string author, string title, BookStatus status)
        // {
        //     Console.WriteLine("-------------");
        //     Console.WriteLine("Powiadomienie dla użytkownika: {0}", this._name);
        //     Console.WriteLine("Książka: {0} autorstwa: {1} posiada status: {2}", title, author, status);
        // }
    }
}
