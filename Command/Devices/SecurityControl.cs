using System;

namespace ProjetoCommand.Devices
{
    public class SecurityControl
    {
        public void Arm()
        {
            Console.WriteLine("Sistema de segurança armado.");
        }

        public void Disarm()
        {
            Console.WriteLine("Sistema de segurança desarmado.");
        }
    }
}
