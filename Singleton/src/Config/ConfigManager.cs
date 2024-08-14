using ProjetoConfig.Models;
using System.IO;
using System.Collections.Generic;

namespace ProjetoConfig.Config
{
    public sealed class ConfigManager
    {
        private static ConfigManager _instance = null;
        private static readonly object _lock = new object();
        public GameConfig Config { get; private set; }

        private ConfigManager()
        {
            LoadConfig();
        }

        public static ConfigManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            _instance = new ConfigManager();
                        }
                    }
                }
                return _instance;
            }
        }

        private void LoadConfig()
        {
            Config = new GameConfig();
            // O caminho agora assume que o arquivo está na saída da compilação
            string configFilePath = Path.Combine(Directory.GetCurrentDirectory(), "Config", "config.txt");

            string[] lines = File.ReadAllLines(configFilePath);
            foreach (var line in lines)
            {
                string[] parts = line.Split('=');
                if (parts.Length == 2)
                {
                    var property = typeof(GameConfig).GetProperty(parts[0]);
                    if (property != null)
                    {
                        if (property.PropertyType == typeof(int))
                        {
                            property.SetValue(Config, int.Parse(parts[1]));
                        }
                        else
                        {
                            property.SetValue(Config, parts[1]);
                        }
                    }
                }
            }
        }
    }
}
