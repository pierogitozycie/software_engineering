using System;

namespace Excel_Cell.ObserverPattern
{
    // Obserwator
    public class Plot : IObserver
    {
        private string _name;

        public Plot(string name)
        {
            this._name = name;
        }

        // Aktualizacja w wersji "PULL" - wyciąganie danych
        public void Update(Cell cell)
        {
            string name = cell.Name;
            byte value = cell.Value;

            string plots = new string('+', value);
            Console.WriteLine("-------------");
            Console.WriteLine("{0}: {1}", _name, plots);

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
