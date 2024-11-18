using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spreadsheet_CommandPattern
{

    class Program
    {

        static void Main(string[] args)
        {
            Spreadsheet arkusz1 = new Spreadsheet("Arkusz1");
            Cell a1 = arkusz1.AddCell("A1");
            Cell b1 = arkusz1.AddCell("B1");

            Console.WriteLine("Wartość {0}: {1}", a1.Name, a1.Value);
            Console.WriteLine("Wartość {0}: {1}", b1.Name, b1.Value);

            Console.WriteLine("Wstawiamy wartość 3 do komórki A1 oraz wartość 11 do B1");
            arkusz1.Insert("A1", 3);
            arkusz1.Insert("B1", 11);

            Console.WriteLine("Wartość {0}: {1}", a1.Name, a1.Value);
            Console.WriteLine("Wartość {0}: {1}", b1.Name, b1.Value);
        

        }
    }
}