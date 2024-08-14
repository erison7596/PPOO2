using System.Collections.Generic;
using System.IO;
using System;

namespace ProjetoCommand.Persistence
{
    public static class CommandHistory
    {
        private const string FilePath = "command_history.txt";

        public static void StoreCommand(string commandName)
        {
            File.AppendAllText(FilePath, commandName + Environment.NewLine);
        }

        public static IEnumerable<string> LoadCommands()
        {
            if (!File.Exists(FilePath))
                return new List<string>();

            return File.ReadAllLines(FilePath);
        }

        public static void ClearHistory()
        {
            File.Delete(FilePath);
        }
    }
}
