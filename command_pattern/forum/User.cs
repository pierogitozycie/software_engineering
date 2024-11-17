using System.Collections.Generic;

namespace Forum_Comments_CommandPattern
{
    public class User
    { 
        private List<ICommand> _commandList = new List<ICommand>();
        private List<ICommand> _executedCommands = new List<ICommand>();

        public void PlaceCommand(ICommand command)
        {
            this._commandList.Add(command);
        }

        public void ExecuteAllCommands()
        {
            foreach (ICommand command in this._commandList)
            {
                command.Execute();
                _executedCommands.Add(command);
            }
            
            this._commandList.Clear();
        }
    }
}
