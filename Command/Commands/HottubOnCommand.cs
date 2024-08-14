using ProjetoCommand.Devices;

namespace ProjetoCommand.Commands
{
    public class HottubOnCommand : DeviceCommand
    {
        private Hottub _hottub;

        public HottubOnCommand(Hottub hottub)
        {
            _hottub = hottub;
        }

        public override void Execute()
        {
            _hottub.On();
            Store();
        }
    }
}
