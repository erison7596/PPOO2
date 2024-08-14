namespace ProjetoConfig.Models
{
    public class GameConfig
    {
        public string AppId { get; set; }
        public string UserName { get; set; }
        public string Language { get; set; }
        public int Offline { get; set; }
        public int AutoDLC { get; set; }
        public string BuildId { get; set; }
        public string DLCName { get; set; }
        public int UpdateDB { get; set; }
        public string Signature { get; set; }
        public string WindowInfo { get; set; }
        public string LVWindowInfo { get; set; }
        public string ApplicationPath { get; set; }
        public string WorkingDirectory { get; set; }
        public int WaitForExit { get; set; }
        public int NoOperation { get; set; }
    }
}
