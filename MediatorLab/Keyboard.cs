using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorLib
{
    public class Keyboard
    {
        private bool enabled;
        private ComputerSystem compsys;

        public Keyboard(ComputerSystem cs)
        {
            compsys = cs;
            enabled = false;
            compsys.RegisterKeyboard(this);
        }
        private bool Enabled()
        {
            return enabled;
        }


        public void Enable()
        {
            enabled = true;
        }
        public void Disable()
        {
            enabled = false;
        }

        public void KeyPressed(char key)
        {
            if (Enabled())
            {
                compsys.KeyboardKeyPressed(key);
            }
        }
    }
}
