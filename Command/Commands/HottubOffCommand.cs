using ProjetoCommand.Devices;

namespace ProjetoCommand.Commands
{
    public class HottubOffCommand : DeviceCommand
    {
        private Hottub _hottub;

        public HottubOffCommand(Hottub hottub)
        {
            _hottub = hottub;
        }

        public override void Execute()
        {
            _hottub.Off();
            Store();
        }
    }
}
