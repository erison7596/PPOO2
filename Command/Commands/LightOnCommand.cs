using ProjetoCommand.Devices;

namespace ProjetoCommand.Commands
{
    public class LightOnCommand : DeviceCommand
    {
        private Light _light;

        public LightOnCommand(Light light)
        {
            _light = light;
        }

        public override void Execute()
        {
            _light.On();
            Store();
        }
    }
}
