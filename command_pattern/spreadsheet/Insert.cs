using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spreadsheet_CommandPattern
{

    public class Insert : ICommand
    {
        private Cell _Cell;
        private int _value;
        private int _oldValue;

        public Insert(Cell cell, int value)
        {
            this._Cell = cell;
            this._value = value;
        }

        public void Execute()
        {
            _oldValue = _Cell.Value;
            _Cell.Value = _value;
        }

        public void Undo()
        {
            _Cell.Value = _oldValue;
        }

    }
}