using System;
using System.Collections.Generic;

namespace Лабораторная_работа__9_формы
{
  public class RectangleArrayClass
  {
    private Rectangle[] array = new Rectangle[50];

    public int Length { get { return array.Length; } }

    public Rectangle this[int index]
    {
      get
      {
        if (index > -1 && index < this.Length)
          return array[index];
        else
          throw new IndexOutOfRangeException();
      }
      set
      {
        if (index > -1 && index < this.Length)
          array[index] = value;
        else
          throw new IndexOutOfRangeException();
      }
    }

    public RectangleArrayClass() //базовый
    {
      for (int i = 0; i < Length; i++)
        array[i] = new Rectangle();
    }

    public RectangleArrayClass(int length) //по заданной длине
    {
      array = new Rectangle[length];
      for (int i = 0; i < length; i++)
        array[i] = new Rectangle();
    }

    public RectangleArrayClass(Random rnd) //rng
    {
      for (int i = 0; i < Length; i++)
        array[i] = new Rectangle(rnd.Next(0, 47000), rnd.Next(0, 47000));
    }

    public RectangleArrayClass(RectangleArrayClass recArr) //copy
    {
      array = new Rectangle[recArr.Length];
      for (int i = 0; i < Length; i++)
        array[i] = new Rectangle(recArr[i].Length, recArr[i].Width);
    }

    public RectangleArrayClass(bool uselessSignal) // метод ручного ввода
    {
      for (int i = 0; i < Length; i++) 
      {
        double length = ReadDouble(), width = ReadDouble();
        array[i] = new Rectangle(length, width);
      }
    }

    public RectangleArrayClass(Rectangle[] arr) // метод ручного ввода с получением массива
    {
      array = arr;
    }

    private double ReadDouble()
    {
      double value = 0;
      while (double.TryParse(Console.ReadLine(), out value)) ;
      return value;
    }

    public override bool Equals(object obj)
    {
      if (obj == null || !(obj is RectangleArrayClass) || ((RectangleArrayClass)obj).Length != this.Length)
        return false;
      else
      {
        for (int i = 0; i < Length; i++)
          if (this[i].Length != ((RectangleArrayClass)obj)[i].Length || this[i].Width != ((RectangleArrayClass)obj)[i].Width)
            return false;
        return true;
      }
    }

    public override int GetHashCode()
    {
      int hashCode = 1638756939;
      hashCode = hashCode * -1521134295 + EqualityComparer<Rectangle[]>.Default.GetHashCode(array);
      hashCode = hashCode * -1521134295 + Length.GetHashCode();
      return hashCode;
    }
  }
}