namespace Auction.ObserverPattern
{
    // Interfejs obserwatora
    public interface IObserver
    {
        // Aktualizacja w wersji PULL
        void Update(Auction auction);

        // Aktualizacja w wersji PUSH
        // void Update(string name, int price);
    }
}
