using System;
using System.Collections.Generic;

namespace Lab3.Servises {
  public class Sinusoid : IGraphics {

    public IDictionary<double, double> CalculatePoints(
        double a,
        double b,
        double c,
        double d,
        double step,
        int yMax,
        int yMin,
        int xMax,
        int xMin
    ) {
      IDictionary<double, double> Points = new Dictionary<double, double>();
      for (double i = xMin; i <= xMax; i += step) {
        double y =Math.Round( a + b * Math.Sin(c * i + d),3);
        Points.Add(i, y);
        Console.Write(y.ToString()+", ");
      }

      Console.WriteLine();



      return Points;
    }
  }
}
