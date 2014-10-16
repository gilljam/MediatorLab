using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorLib
{
    public class Computer
    {

        private ComputerSystem compsys;

        public Computer(ComputerSystem cs)
        {
            compsys = cs;
            compsys.RegisterComputer(this);
        }

        public void SwitchOn()
        {
            compsys.ComputerSwitchedOn();
        }

        public void SwitchOff()
        {
            compsys.ComputerSwitchedOff();
        }
    }
}
