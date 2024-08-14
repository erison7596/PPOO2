using System;

namespace ProjetoCommand.Devices
{
    public class GarageDoor
    {
        public void Up()
        {
            Console.WriteLine("Porta da garagem levantada.");
        }

        public void Down()
        {
            Console.WriteLine("Porta da garagem abaixada.");
        }
    }
}
