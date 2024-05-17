using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndComposition
{
    public class Monitor
    {
        // Example for Composition Relationship between classes
        private Resolution resolution; // Monitor HAS-A Resolution

        public Monitor()
        {

        }

        public Monitor(Resolution resolution)
        {
            this.Resolution = resolution;
        }

        public Resolution Resolution { get { return resolution; } set { resolution = value; }  }
    }
}
