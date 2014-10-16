using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorLib
{
    public class ComputerSystem
    {
        private Computer computer;
        private Screen screen;
        private Keyboard keyboard;

        public void RegisterComputer(Computer c)
        {
            computer = c;
        }

        public void RegisterScreen(Screen s)
        {
            screen = s;
        }

        public void RegisterKeyboard(Keyboard k)
        {
            keyboard = k;
        }
        public void ComputerSwitchedOn()
        {
            keyboard.Enable();
        }

        public void ComputerSwitchedOff()
        {
            keyboard.Disable();
        }

        public void KeyboardKeyPressed(char key)
        {
            if (screen.IsOn())
            {
                screen.CharacterToDisplay = key;
                screen.DisplayCharacter();
            }
        }
    }
}
