using System.Collections.Generic;

namespace pattern_command.UndoCommand
{
    public class History
    {
        private Stack<UndoableCommand> _histories;
        public History()
        {
            _histories = new Stack<UndoableCommand>();
        }

        public void Push(UndoableCommand command)
        {
            _histories.Push(command);
        }

        public UndoableCommand Pop()
        {
            return _histories.Pop();
        }

        public int Size => _histories.Count;
    }
}