using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MediatorLib;

namespace MediatorTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ComputerSystemTest()
        {
            ComputerSystem compsys = new ComputerSystem();
            Computer computer = new Computer(compsys);
            Keyboard keyboard = new Keyboard(compsys);
            Screen screen = new Screen(compsys);
            computer.SwitchOn();
            screen.TurnOn();
            keyboard.KeyPressed('a');

            Assert.AreEqual('a', screen.DisplayCharacter());
        }
    }
}
