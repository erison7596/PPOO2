namespace ProjetoCommand.Commands
{
    public interface ICommand
    {
        void Execute();
        void Store();
        void Load();
    }
}
