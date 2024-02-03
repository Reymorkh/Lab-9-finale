using System;

namespace Лабораторная_работа__9_формы
{
  public class Rectangle
  {
    private static int count = 0;

    private double length = 0.0001, width = 0.0001;

    #region EditParams
    public void EditLength(double len) => Length += len;

    public void EditWidth(double wid) => Width += wid;

    public void Multiply(double multiplier) => (Length, Width) = (Length * multiplier, Width * multiplier);

    public static void MultiplyStatic(double multiplier, Rectangle rect) => (rect.Length, rect.Width) = (rect.Length * multiplier, rect.Width * multiplier);
    #endregion

    #region GetParams
    public double Length
    {
      get
      {
        return length;
      }
      set
      {
        if (value > 46340.95)
          length = 46340.95;
        else
          if (value < 0.0001)
          length = 0.0001;
        else
          length = value;
      }
    }

    public double Width
    {
      get
      {
        return width;
      }
      set
      {
        if (value > 46340.9499)
          width = 46340.9499;
        else
          if (value < 0.0001)
          width = 0.0001;
        else
          width = value;
      }
    }

    public static int Count { get { return count; } }
    #endregion

    #region Конструкторы
    public Rectangle()
    {
      count++;
    }

    public Rectangle(double len, double wid)
    {
      Length = len;
      Width = wid;
      count++;
    }

    public Rectangle(Rectangle rect) => (length, width) = (rect.Length, rect.Width);
    #endregion

    public static Rectangle operator ++(Rectangle rect) => new Rectangle(rect.Length + 1, rect.Width + 1);
    public static Rectangle operator --(Rectangle rect) => new Rectangle(rect.Length - 1, rect.Width - 1);

    public static explicit operator double (Rectangle rect) => Math.Sqrt(Math.Pow(rect.Length, 2) + Math.Pow(rect.Width, 2)) / 2;
    public static implicit operator bool(Rectangle rect) => rect.Length == rect.Width;

   // public override bool Equals(object obj) { return true; }
  }
}
