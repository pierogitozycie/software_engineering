using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spreadsheet_CommandPattern
{

    public class Spreadsheet
    {
        private string _name;
        private History _history = new History();
        private Dictionary<string, Cell> _cells = new Dictionary<string, Cell>();

        public string Name
        {
            get { return this._name; }
        }

        public Spreadsheet(string name)
        {
            this._name = name;
        }

        public void Undo()
        {
            _history.Undo();
        }

        // tutaj zmieniamy wartosć komórki o nazwie name na value, 
        // a następnie dodajemy do historii operację Insert
        // a metoda Add w klasie History dodaje operację do listy i wykonuje ją
        public void Insert(string name, int value)
        {
            _history.AddAndExecute(new Insert(_cells[name], value));
        }

        public Cell AddCell(string name)
        {
            Cell cell = new Cell(name, 0);
            _cells.Add(name, cell);
            return cell;
        }
    }
}
