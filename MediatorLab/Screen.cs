using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorLib
{
    public class Screen
    {
        private ComputerSystem compsys;
        private bool on;
        public char CharacterToDisplay { get; set; }

        public Screen(ComputerSystem cs)
        {
            compsys = cs;
            on = false;
            compsys.RegisterScreen(this);
        }

        public bool IsOn()
        {
            return on;
        }
        public void TurnOn()
        {
            on = true;
        }

        public void TurnOff()
        {
            on = false;
        }

        public char DisplayCharacter()
        {
            return CharacterToDisplay;
        }
    }
}
