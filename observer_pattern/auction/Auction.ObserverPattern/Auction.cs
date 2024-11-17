namespace Auction.ObserverPattern
{
    // Obserwowany podmiot
    public class Auction : Subject
    {
        private string _name;
        public string Name => this._name;
        private int _price;
        
        public int Price 
        {
            get => this._price;
            set
            {
                this._price = value;
                Notify();
            }
        }
        public Auction(string name, int price)
        {
            this._name = name;
            this._price = price;
        }

        // powiadamianie obserwatorów
        protected override void Notify()
        {
            foreach (IObserver observer in this._observerList)
            {
                // Wersja "PULL"
                observer.Update(this);

                // Wersja "PUSH"
                // observer.Update(this._name, this._price);
            }
        }
    }
}
