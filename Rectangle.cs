using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classhinhchunhat
{
    class Rectangle
    {
        private int width;
        private int height;

        public Rectangle(int width = 1, int height = 1)
        {
            this.Width = width;
            this.Height = height;
        }

        public int Width { get => width; set => width = value; }
        public int Height { get => height; set => height = value; }
        public int getArea() { return width * height; }
        public int getPer() { return 2 * (width + height); }
        public string Display()
        {
            return "Rectangle{" + "width=" + width + ", height=" + height + "}";

        }
    }
}
