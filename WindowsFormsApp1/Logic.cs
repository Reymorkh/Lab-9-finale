using System;
using System.Collections.Generic;

namespace Лабораторная_работа__9_формы
{
  public static class Logic
  {
    public static List<Rectangle> Rectangles = new List<Rectangle>();
    public static List<RectangleArrayClass> RectangleArrays = new List<RectangleArrayClass>();
    public static int CopyIndex = -1, CopyIndexPart3 = -1;

    public static void CreateRectangleArray() => RectangleArrays.Add(new RectangleArrayClass());

    public static void CreateRectangleArray(int length) => RectangleArrays.Add(new RectangleArrayClass(length));

    public static void CreateRectangleArray(Random rnd) => RectangleArrays.Add(new RectangleArrayClass(rnd));

    public static void CreateRectangle(double length, double width) => Rectangles.Add(new Rectangle(length, width));

    public static void CreateRectangle() => Rectangles.Add(new Rectangle());
  }
}
