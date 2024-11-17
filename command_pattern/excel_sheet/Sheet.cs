using System;
using System.Security.Authentication;

namespace Excel_Sheet_CommandPattern
{

    public class Sheet
    {

        private List<Cell> _cells = new List<Cell>();
        private Stack<ICommand> _commandHistory = new Stack<ICommand>();

        public void AddCell(Cell cell)
        {
            _cells.Add(cell);
        }
        

    }
    
}

