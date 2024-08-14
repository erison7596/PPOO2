using ProjetoCommand.Devices;

namespace ProjetoCommand.Commands
{
    public class SoundOnCommand : DeviceCommand
    {
        private Sound _sound;

        public SoundOnCommand(Sound sound)
        {
            _sound = sound;
        }

        public override void Execute()
        {
            _sound.On();
            Store();
        }
    }
}
