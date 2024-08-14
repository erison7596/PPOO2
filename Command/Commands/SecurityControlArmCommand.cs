using ProjetoCommand.Devices;

namespace ProjetoCommand.Commands
{
    public class SecurityControlArmCommand : DeviceCommand
    {
        private SecurityControl _securityControl;

        public SecurityControlArmCommand(SecurityControl securityControl)
        {
            _securityControl = securityControl;
        }

        public override void Execute()
        {
            _securityControl.Arm();
            Store();
        }
    }
}
