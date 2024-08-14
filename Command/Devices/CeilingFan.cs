using System;

namespace ProjetoCommand.Devices
{
    public class CeilingFan
    {
        public void High()
        {
            Console.WriteLine("Ventilador de teto na alta velocidade.");
        }

        public void Off()
        {
            Console.WriteLine("Ventilador de teto desligado.");
        }
    }
}
