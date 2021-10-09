using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    class TurnOnCommand : ICommand
    {
        private readonly Fan fan;
        public TurnOnCommand(Fan _fan)
        {
            fan = _fan;
        }
        public void Execute()
        {
            fan.TurnOn();
        }

        public void Undo()
        {
            fan.TurnOff();
        }
    }
}