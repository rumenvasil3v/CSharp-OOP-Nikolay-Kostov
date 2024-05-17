using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndComposition
{
    public class Mouse : PeripheralDevice
    {
        private string model;

        public Mouse()
        {

        }

        public string Model { get { return model; } set {  model = value; } }
    }
}
