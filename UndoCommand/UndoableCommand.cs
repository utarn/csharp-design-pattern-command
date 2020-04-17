namespace pattern_command.UndoCommand
{
    public interface UndoableCommand : Command
    {
        void UnExecute();
    }

    // Resize 1080p -> 720p
    // Memento : เก็บรูปภาพ 1080p , 720p
    // Command : resolution ก่อน, หลัง
}