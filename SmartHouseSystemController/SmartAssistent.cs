using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHouseSystemController
{
    class CommandsCollection : List<ICommand> { }
    class SmartAssistent
    {
        public CommandsCollection Commands { get; }
        public SmartAssistent()
        {
            Commands = new();
        }
        public void AddCommand(ICommand command) => Commands.Add(command);
        public void ExecuteCommands()
        {
            Commands.ForEach(c => c.Execute());
        }
        public void UndoCommands()
        {
            Commands.ForEach(c => c.Undo());
        }
    }
}
