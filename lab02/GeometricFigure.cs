using System;
using System.Collections.Generic;
using System.Text;

namespace lab02
{
    public abstract class GeometricFigure : IComparable
    {
        public abstract double Square();
        public int CompareTo(object obj)
        {
            GeometricFigure temp = obj as GeometricFigure;
            return this.Square().CompareTo(temp.Square());
        }
    }
}
