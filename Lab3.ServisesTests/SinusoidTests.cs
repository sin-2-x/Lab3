using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab3.Servises;
using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Lab3.Servises.Tests {
  [TestClass()]
  public class SinusoidTests {
    private static Sinusoid sinusoid = new Sinusoid();
    [TestMethod()]
    public void CalculatePointsTest1() {
      IDictionary<double, double> Points = sinusoid.CalculatePoints(0, 0, 1, 0, 1, 10, 0, 10, 0);
      List<double> p = new List<double>(Points.Values);
      List<double> q = new List<double>() { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
      if (p.Count != q.Count)
        Assert.Fail();
      for (int i = 0; i < p.Count; i++) {
        if (p[i] != q[i])
          Assert.Fail();
      }
    }
    [TestMethod()]
    public void CalculatePointsTest2() {//
      IDictionary<double, double> Points = sinusoid.CalculatePoints(0, 1, 1, 0, 1, 10, 0, 10, 0);
      List<double> p = new List<double>(Points.Values);
      List<double> q = new List<double>() { 0, 0.841, 0.909, 0.141, -0.757, -0.959, -0.279, 0.657, 0.989, 0.412, -0.544 };
      if (p.Count != q.Count)
        Assert.Fail();
      for (int i = 0; i < p.Count; i++) {
        if (p[i] != q[i])
          Assert.Fail();
      }
    }
    [TestMethod()]
    public void CalculatePointsTest3() {
      IDictionary<double, double> Points = sinusoid.CalculatePoints(22, 1, 1, 0, 1, 10, 0, 10, 0);
      List<double> p = new List<double>(Points.Values);
      List<double> q = new List<double>() { 22, 22.841, 22.909, 22.141, 21.243, 21.041, 21.721, 22.657, 22.989, 22.412, 21.456 };
      if (p.Count != q.Count)
        Assert.Fail();
      for (int i = 0; i < p.Count; i++) {
        if (p[i] != q[i])
          Assert.Fail();
      }
    }
    [TestMethod()]
    public void CalculatePointsTest4() {
      IDictionary<double, double> Points = sinusoid.CalculatePoints(0, 1, 1, -100, 1, 10, 0, 10, 0);
      List<double> p = new List<double>(Points.Values);
      List<double> q = new List<double>() { 0.506, 0.999, 0.573, -0.38, -0.984, -0.683, 0.245, 0.948, 0.779, -0.106, -0.894 };
      if (p.Count != q.Count)
        Assert.Fail();
      for (int i = 0; i < p.Count; i++) {
        if (p[i] != q[i])
          Assert.Fail();
      }
    }
  }
}