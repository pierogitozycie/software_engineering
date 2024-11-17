namespace Excel_Cell.ObserverPattern
{
    // Interfejs obserwatora
    public interface IObserver
    {
        // Aktualizacja w wersji PULL
        void Update(Cell cell);

        // Aktualizacja w wersji PUSH
        // void Update(string name, byte value);
    }
}
