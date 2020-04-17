using System.Collections.Generic;

namespace pattern_command
{
    public class CompositeCommand : Command
    {
        public List<Command> Commands { get; private set; }
        public CompositeCommand()
        {
            Commands = new List<Command>();
        }
        public void Execute()
        {
            foreach (var command in Commands)
            {
                command.Execute();
            }
        }
    }
}