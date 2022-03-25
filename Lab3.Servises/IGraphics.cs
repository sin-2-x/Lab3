using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3.Servises
{
    public interface IGraphics
    {
        IDictionary<double, double> CalculatePoints(
            double a,
            double b,
            double c,
            double d,
            double step,
            int yMax,
            int yMin,
            int xMax,
            int xMin
        );
    }
}
