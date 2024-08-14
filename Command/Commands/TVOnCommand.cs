using ProjetoCommand.Devices;

namespace ProjetoCommand.Commands
{
    public class TVOnCommand : DeviceCommand
    {
        private TV _tv;

        public TVOnCommand(TV tv)
        {
            _tv = tv;
        }

        public override void Execute()
        {
            _tv.On();
            Store();
        }
    }
}
