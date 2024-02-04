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

    public RectangleArray()
    {
      for (int i = 0; i < Length; i++)
        array[i] = new Rectangle();
    }

    public RectangleArray(int length) 
    {
      array = new Rectangle[length]; 
    for (int i = 0; i < length; i++)
        array[i] = new Rectangle();
    }

    public RectangleArray(Random rnd)
    {
      for (int i = 0; i < Length; i++)
        array[i] = new Rectangle(rnd.Next(0, 47000), rnd.Next(0, 47000));
    }

    public RectangleArray(RectangleArray recArr)
    {
      array = new Rectangle[recArr.Length];
      for (int i = 0; i < Length; i++)
        array[i] = new Rectangle(recArr[i].Length, recArr[i].Width);
    }

  }
}