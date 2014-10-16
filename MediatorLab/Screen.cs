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

        public Screen(ComputerSystem cs)
        {
            compsys = cs;
        }
        public void TurnOn()
        {

        }

        public void TurnOff()
        {

        }

        public char DisplayCharacter()
        {
            throw new NotImplementedException();
        }
    }
}
