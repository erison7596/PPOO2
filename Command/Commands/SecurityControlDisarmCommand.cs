using ProjetoCommand.Devices;

namespace ProjetoCommand.Commands
{
    public class SecurityControlDisarmCommand : DeviceCommand
    {
        private SecurityControl _securityControl;

        public SecurityControlDisarmCommand(SecurityControl securityControl)
        {
            _securityControl = securityControl;
        }

        public override void Execute()
        {
            _securityControl.Disarm();
            Store();
        }
    }
}
