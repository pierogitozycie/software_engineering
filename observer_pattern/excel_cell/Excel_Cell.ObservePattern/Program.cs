using System;

namespace Excel_Cell.ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Cell komorka1 = new Cell("A1", 4);
            Cell komorka2 = new Cell("B1", 3);

            Plot plot1 = new Plot("Plot1");

            komorka1.Attach(plot1);
            komorka1.Attach(komorka2);

            komorka1.Value = 12;
        }

    }
}

