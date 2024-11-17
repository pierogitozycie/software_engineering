namespace Excel_Sheet_CommandPattern
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }
}