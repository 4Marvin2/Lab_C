using System;
using System.Collections.Generic;
using System.Text;

namespace lab02
{
    public class Quadrate : Rectangle
    {
        public Quadrate(float length) : base(length, length)
        {
            this.Width = length;
            this.Height = length;
        }
    }
}
