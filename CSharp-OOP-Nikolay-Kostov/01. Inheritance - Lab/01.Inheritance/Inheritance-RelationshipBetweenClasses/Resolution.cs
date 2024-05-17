using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndComposition
{
    public sealed class Resolution
    {
        private int heightPixels;
        private int widthPixels;

        public Resolution()
        {
            this.HeightPixels = 1080;
            this.WidthPixels = 1920;
        }

        public int HeightPixels { get { return heightPixels; } set {  heightPixels = value; } }

        public int WidthPixels { get { return widthPixels; } set {  widthPixels = value; } }
    }
}
