using System;
using System.IO;

namespace ProjetoCommand.Commands
{
    public abstract class DeviceCommand : ICommand
    {
        public abstract void Execute();

        public virtual void Store()
        {
            // Armazena o comando em um arquivo
            File.AppendAllText("command_history.txt", this.GetType().Name + Environment.NewLine);
        }

        public virtual void Load()
        {
            // Carrega comandos do arquivo
            var commands = File.ReadAllLines("command_history.txt");
            foreach (var command in commands)
            {
                Console.WriteLine($"Executando comando: {command}");
                var commandInstance = (ICommand)Activator.CreateInstance(Type.GetType(command));
                commandInstance.Execute();
            }
        }
    }
}
