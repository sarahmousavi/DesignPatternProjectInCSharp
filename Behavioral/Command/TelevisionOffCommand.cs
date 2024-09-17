﻿using Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class TelevisionOffCommand : ICommand
    {
        private readonly Television _television;
        public TelevisionOffCommand(Television television)
        {
            _television = television;
        }
        public void Execute()
        {
            _television.TurnOff();
        }

        public void Undo()
        {
            _television.TurnOn();
        }
    }
}