using System;

namespace Лабораторная_работа__9_формы
{
  public class RectangleArray
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
          throw new Exception("Index was out of Range");
      }
      set
      {
        if (index > -1 && index < this.Length)
          array[index] = value;
        else
          throw new Exception("Index was out of Range");
      }
    }

    public RectangleArray() { }

    public RectangleArray(Random rnd) 
    {
      for (int i = 0; i < array.Length; i++)
      {
        array[i].Length = rnd.Next(0, 47000);
        array[i].Width = rnd.Next(0, 47000);
      }
    }

    public RectangleArray(Rectangle[] arr)
    {

    }

  }
}