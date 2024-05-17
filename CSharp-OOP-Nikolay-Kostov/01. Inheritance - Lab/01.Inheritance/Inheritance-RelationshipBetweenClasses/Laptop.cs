using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndComposition
{
    // Example for Composition
    public class Laptop
    {
        private Monitor monitor;
        private Keyboard keyboard;
        private Mouse mouse;

        public Laptop()
        {
            this.Monitor = new Monitor();
            this.Keyboard = new Keyboard();
            this.Mouse = new Mouse();
        }

        // Laptop HAS-A Monitor, but Laptop cannot derive from Monitor
        public Monitor Monitor { get { return monitor; } set { monitor = value; } }

        // Laptop HAS-A Keyboard, but Laptop cannot derive from Keyboard
        public Keyboard Keyboard { get { return keyboard; } set { keyboard = value; } }

        // Laptop HAS-A Mouse, but Laptop cannot derive from Mouse
        public Mouse Mouse { get { return mouse; } set { mouse = value; } }
    }
}