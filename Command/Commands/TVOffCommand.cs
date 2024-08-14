using ProjetoCommand.Devices;

namespace ProjetoCommand.Commands
{
    public class TVOffCommand : DeviceCommand
    {
        private TV _tv;

        public TVOffCommand(TV tv)
        {
            _tv = tv;
        }

        public override void Execute()
        {
            _tv.Off();
            Store();
        }
    }
}
