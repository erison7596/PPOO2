using System;

namespace ProjetoCommand.Devices
{
    public class TV
    {
        public void On()
        {
            Console.WriteLine("TV ligada.");
        }

        public void Off()
        {
            Console.WriteLine("TV desligada.");
        }
    }
}
