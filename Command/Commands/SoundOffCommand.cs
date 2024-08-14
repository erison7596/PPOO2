using ProjetoCommand.Devices;

namespace ProjetoCommand.Commands
{
    public class SoundOffCommand : DeviceCommand
    {
        private Sound _sound;

        public SoundOffCommand(Sound sound)
        {
            _sound = sound;
        }

        public override void Execute()
        {
            _sound.Off();
            Store();
        }
    }
}
