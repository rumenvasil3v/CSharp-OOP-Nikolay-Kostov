using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ClassBoxData
{
    public class Box
    {
        const string ExceptionMessage = "{0} cannot be zero or negative.";

        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }

        public double Length
        {
            get { return this.length; }
            private set
            {
                ValidateSize(value, string.Format(ExceptionMessage, nameof(Length)));

                this.length = value;
            }
        }

        public double Width
        {
            get { return this.width; }
            private set
            {
                ValidateSize(value, string.Format(ExceptionMessage, nameof(Width)));

                this.width = value;
            }
        }

        public double Height
        {
            get { return this.height; }
            private set
            {
                ValidateSize(value, string.Format(ExceptionMessage, nameof(Height)));

                this.height = value;
            }
        }

        private void ValidateSize(double value, string message)
        {
            if (value <= 0)
            {
                throw new ArgumentException(message);
            }
        }

        public double SurfaceArea()
        {
            // Surface area = 2lw + 2lh + 2wh
            double surfaceArea = 2 * this.Length * this.Width + 2 * this.Length * this.Height + 2 * this.Width * this.Height;

            return surfaceArea;
        }

        public double LateralSurfaceArea()
        {
            // Lateral Surface Area = 2lh + 2wh
            double lateralSurfaceArea = 2 * this.Length * this.Height + 2 * this.Width * this.Height;

            return lateralSurfaceArea;
        }

        public double Volume()
        {
            // Volume = lwh
            double volume = this.Length * this.Width * this.Height;

            return volume;
        }

        public override string ToString()
        {
            StringBuilder sb = new();

            sb.AppendLine($"Surface Area - {this.SurfaceArea():f2}");
            sb.AppendLine($"Lateral Surface Area - {this.LateralSurfaceArea():f2}");
            sb.Append($"Volume - {this.Volume():f2}");

            return sb.ToString();
        }
    }
}
