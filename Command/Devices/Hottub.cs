using System;

namespace ProjetoCommand.Devices
{
    public class Hottub
    {
        public void On()
        {
            Console.WriteLine("Banheira de hidromassagem ligada.");
        }

        public void Off()
        {
            Console.WriteLine("Banheira de hidromassagem desligada.");
        }
    }
}
