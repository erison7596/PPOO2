using ProjetoCommand.Devices;

namespace ProjetoCommand.Commands
{
    public class GarageDoorUpCommand : DeviceCommand
    {
        private GarageDoor _garageDoor;

        public GarageDoorUpCommand(GarageDoor garageDoor)
        {
            _garageDoor = garageDoor;
        }

        public override void Execute()
        {
            _garageDoor.Up();
            Store();
        }
    }
}
