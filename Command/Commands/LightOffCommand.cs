using ProjetoCommand.Devices;

namespace ProjetoCommand.Commands
{
    public class LightOffCommand : DeviceCommand
    {
        private Light _light;

        public LightOffCommand(Light light)
        {
            _light = light;
        }

        public override void Execute()
        {
            _light.Off();
            Store();
        }
    }
}
