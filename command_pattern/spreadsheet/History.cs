using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Spreadsheet_CommandPattern
{
    public class History
    {
        private Stack<ICommand> _commands = new Stack<ICommand>();

        public void AddAndExecute(ICommand command)
        {
            _commands.Push(command);
            command.Execute();

        }

        public void Undo()
        {
            if (_commands.Any())
            {
                _commands.Pop().Undo();
            }
            else
            {
                Console.WriteLine("Historia jest pusta!");
            }
        }

    }

}