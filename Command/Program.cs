using ProjetoCommand.Commands;
using ProjetoCommand.Devices;
using ProjetoCommand.Invoker;
using ProjetoCommand.Persistence;
using System;

namespace ProjetoCommand
{
    class Program
    {
        static void Main(string[] args)
        {
            var remoteControl = new RemoteControl();

            // Configurando os dispositivos
            var light = new Light();
            var lightOn = new LightOnCommand(light);
            var lightOff = new LightOffCommand(light);

            var ceilingFan = new CeilingFan();
            var ceilingFanHigh = new CeilingFanHighCommand(ceilingFan);
            var ceilingFanOff = new CeilingFanOffCommand(ceilingFan);

            var garageDoor = new GarageDoor();
            var garageDoorUp = new GarageDoorUpCommand(garageDoor);
            var garageDoorDown = new GarageDoorDownCommand(garageDoor);

            var hottub = new Hottub();
            var hottubOn = new HottubOnCommand(hottub);
            var hottubOff = new HottubOffCommand(hottub);

            var securityControl = new SecurityControl();
            var securityControlArm = new SecurityControlArmCommand(securityControl);
            var securityControlDisarm = new SecurityControlDisarmCommand(securityControl);

            var sound = new Sound();
            var soundOn = new SoundOnCommand(sound);
            var soundOff = new SoundOffCommand(sound);

            var tv = new TV();
            var tvOn = new TVOnCommand(tv);
            var tvOff = new TVOffCommand(tv);

            // Simulação de execução de comandos
            remoteControl.SetCommand(lightOn);
            remoteControl.PressButton();

            remoteControl.SetCommand(ceilingFanHigh);
            remoteControl.PressButton();

            remoteControl.SetCommand(garageDoorUp);
            remoteControl.PressButton();

            remoteControl.SetCommand(hottubOn);
            remoteControl.PressButton();

            remoteControl.SetCommand(securityControlArm);
            remoteControl.PressButton();

            remoteControl.SetCommand(soundOn);
            remoteControl.PressButton();

            remoteControl.SetCommand(tvOn);
            remoteControl.PressButton();

            // Simulação de falha e recuperação
            Console.WriteLine("\nRecuperando comandos após falha...\n");
            remoteControl.SetCommand(new LoadCommandsCommand()); 
            remoteControl.PressButton();
        }
    }
}
