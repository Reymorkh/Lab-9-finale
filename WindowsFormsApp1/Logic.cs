using System;
using System.Collections.Generic;

namespace Лабораторная_работа__9_формы
{
  public static class Logic
  {
    public static List<Rectangle> Rectangles = new List<Rectangle>();
    public static List<RectangleArray> RectangleArrays = new List<RectangleArray>();
    public static int CopyIndex = -1, CopyIndexPart3 = -1;

    public static void CreateRectangleArray() => RectangleArrays.Add(new RectangleArray());

    public static void CreateRectangleArray(Random rnd) => RectangleArrays.Add(new RectangleArray(rnd));

    public static void CreateRectangle(double length, double width) => Rectangles.Add(new Rectangle(length, width));

    public static void CreateRectangle() => Rectangles.Add(new Rectangle());
  }
}
