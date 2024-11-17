using System.Collections.Generic;

namespace Auction.ObserverPattern
{
    // Obserwowany podmiot
    public abstract class Subject
    {
        // lista obserwatorów
        protected List<IObserver> _observerList = new List<IObserver>();

        // dodanie nowego obserwatora
        public void Attach(IObserver observer)
        {
            if (!this._observerList.Contains(observer))
                this._observerList.Add(observer);
        }

        // usunięcie danego obserwatora
        public void Detach(IObserver observer)
        {
            if (this._observerList.Contains(observer))
                this._observerList.Remove(observer);
        }

        // powiadamianie obserwatorów o zmianie danych w obserwowanym podmiocie (Book)
        // implementacja powiadomienia znajduje się w klasie pochodnej Book
        abstract protected void Notify();
    }
}
