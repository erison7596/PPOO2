using ProjetoCommand.Devices;

namespace ProjetoCommand.Commands
{
    public class GarageDoorDownCommand : DeviceCommand
    {
        private GarageDoor _garageDoor;

        public GarageDoorDownCommand(GarageDoor garageDoor)
        {
            _garageDoor = garageDoor;
        }

        public override void Execute()
        {
            _garageDoor.Down();
            Store();
        }
    }
}
