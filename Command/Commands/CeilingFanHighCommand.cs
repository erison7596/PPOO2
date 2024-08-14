using ProjetoCommand.Devices;

namespace ProjetoCommand.Commands
{
    public class CeilingFanHighCommand : DeviceCommand
    {
        private CeilingFan _ceilingFan;

        public CeilingFanHighCommand(CeilingFan ceilingFan)
        {
            _ceilingFan = ceilingFan;
        }

        public override void Execute()
        {
            _ceilingFan.High();
            Store();
        }
    }
}
