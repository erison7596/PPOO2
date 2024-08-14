using System;

namespace ProjetoCommand.Devices
{
    public class Light
    {
        public void On()
        {
            Console.WriteLine("Luz ligada.");
        }

        public void Off()
        {
            Console.WriteLine("Luz desligada.");
        }
    }
}
