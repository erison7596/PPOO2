using ProjetoCommand.Devices;

namespace ProjetoCommand.Commands
{
    public class CeilingFanOffCommand : DeviceCommand
    {
        private CeilingFan _ceilingFan;

        public CeilingFanOffCommand(CeilingFan ceilingFan)
        {
            _ceilingFan = ceilingFan;
        }

        public override void Execute()
        {
            _ceilingFan.Off();
            Store();
        }
    }
}
