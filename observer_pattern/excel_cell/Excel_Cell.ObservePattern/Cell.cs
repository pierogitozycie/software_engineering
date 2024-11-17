namespace Excel_Cell.ObserverPattern
{
    // Obserwowany podmiot
    public class Cell : Subject, IObserver
    {
        private string _name;
        public string Name => this._name;
        private byte _value;
        
        public byte Value 
        {
            get => this._value;
            set
            {
                this._value = value;
                Notify();
            }
        }
        public Cell(string name, byte value)
        {
            this._name = name;
            this._value = value;
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

        public void Update(Cell cell)
        {
            string name = cell.Name;
            byte value = cell.Value;

            _value = value;
            Console.WriteLine("-------------");
            Console.WriteLine("Komórka {0} zmieniła wartość na {1}!", name, value);
            Console.WriteLine("Wartość {0}: to {1}", _name, _value);

        }
    }
}
