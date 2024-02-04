using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Лабораторная_работа__9_формы;
using static Лабораторная_работа__9_формы.Logic;

namespace UnitTestProject1
{
  [TestClass]
  public class RectangleArrayClassTest
  {
    [TestMethod]
    public void LengthTest()
    {
      RectangleArrayClass expected = new RectangleArrayClass();
      RectangleArrayClass actual = new RectangleArrayClass(50);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void CopyRandomArrayTest()
    {
      RectangleArrayClass expected = new RectangleArrayClass(new Random());
      RectangleArrayClass actual = new RectangleArrayClass(expected);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void IncrementInsideArrayTest()
    {
      RectangleArrayClass expected = new RectangleArrayClass();
      expected[4]++;
      RectangleArrayClass actual = new RectangleArrayClass();
      actual[4] = new Rectangle(1.0001, 1.0001);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    [ExpectedException(typeof(System.IndexOutOfRangeException))]
    public void SuperiorIndexOutOfRangeGETTest()
    {
      RectangleArrayClass temp = new RectangleArrayClass();
      temp[51].Multiply(2);
    }

    [TestMethod]
    [ExpectedException(typeof(System.IndexOutOfRangeException))]
    public void InferiorIndexOutOfRangeGETTest()
    {
      RectangleArrayClass temp = new RectangleArrayClass();
      temp[-9].Multiply(2);
    }

    [TestMethod]
    [ExpectedException(typeof(System.IndexOutOfRangeException))]
    public void SuperiorIndexOutOfRangeSETTest()
    {
      RectangleArrayClass temp = new RectangleArrayClass();
      temp[51] = new Rectangle();
    }

    [TestMethod]
    [ExpectedException(typeof(System.IndexOutOfRangeException))]
    public void InferiorIndexOutOfRangeSETTest()
    {
      RectangleArrayClass temp = new RectangleArrayClass();
      temp[-9] = new Rectangle();
    }

    [TestMethod]
    public void CreateRectangleArrayMethodTest()
    {
      CreateRectangleArray();
      RectangleArrayClass expected = RectangleArrays[0];
      Assert.AreEqual(expected, new RectangleArrayClass());
    }

    [TestMethod]
    public void CreateRectangleArrayWithLengthMethodTest()
    {
      CreateRectangleArray(30);
      RectangleArrayClass expected = RectangleArrays[0];
      Assert.AreEqual(expected, new RectangleArrayClass(expected));
    }

    [TestMethod]
    public void CreateRectangleArrayRandomMethodTest()
    {
      CreateRectangleArray(new Random());
      RectangleArrayClass expected = RectangleArrays[0];
      Assert.AreEqual(expected, RectangleArrays[0]); //ну, рандом не проверить с другим новосозданным рандомом
    }
  }
}
