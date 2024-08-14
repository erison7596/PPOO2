using ProjetoConfig.Config;
using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var config = ConfigManager.Instance.Config;
            Console.WriteLine("Configurações do jogo:");
            Console.WriteLine($"AppId: {config.AppId}");
            Console.WriteLine($"UserName: {config.UserName}");
            Console.WriteLine($"Language: {config.Language}");
            Console.WriteLine($"Offline: {config.Offline}");
            Console.WriteLine($"AutoDLC: {config.AutoDLC}");
            Console.WriteLine($"BuildId: {config.BuildId}");
            Console.WriteLine($"DLCName: {config.DLCName}");
            Console.WriteLine($"UpdateDB: {config.UpdateDB}");
            Console.WriteLine($"Signature: {config.Signature}");
            Console.WriteLine($"WindowInfo: {config.WindowInfo}");
            Console.WriteLine($"LVWindowInfo: {config.LVWindowInfo}");
            Console.WriteLine($"ApplicationPath: {config.ApplicationPath}");
            Console.WriteLine($"WorkingDirectory: {config.WorkingDirectory}");
            Console.WriteLine($"WaitForExit: {config.WaitForExit}");
            Console.WriteLine($"NoOperation: {config.NoOperation}");
        }
    }
}
