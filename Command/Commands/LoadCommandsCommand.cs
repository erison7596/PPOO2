using ProjetoCommand.Persistence;

namespace ProjetoCommand.Commands
{
    public class LoadCommandsCommand : DeviceCommand
    {
        public override void Execute()
        {
            var commands = CommandHistory.LoadCommands();
            foreach (var commandName in commands)
            {
                Console.WriteLine($"Recuperando e executando comando: {commandName}");
                var commandType = Type.GetType(commandName);
                if (commandType != null)
                {
                    var commandInstance = (ICommand)Activator.CreateInstance(commandType);
                    commandInstance.Execute();
                }
            }
        }
    }
}
