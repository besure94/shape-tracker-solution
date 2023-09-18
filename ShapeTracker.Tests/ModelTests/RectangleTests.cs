using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeTracker.Models;
using System.Collections.Generic;
using System;

namespace ShapeTracker.Tests
{
  [TestClass]
  public class RectangleTests : IDisposable
  {
    public void Dispose()
    {
      Rectangle.ClearAll();
    }

    [TestMethod]
    public void RectangleConstructor_CreatesInstanceOfRectangle_Rectangle()
    {
      Rectangle newRectangle = new Rectangle(6, 3, 6, 3);
      Assert.AreEqual(typeof(Rectangle), newRectangle.GetType());
    }

    [TestMethod]
    public void GetSide1_ReturnsSide1_Int()
    {
      int length1 = 3;
      Rectangle newRectangle = new Rectangle(length1, 6, 3, 6);
      int result = newRectangle.Side1;
      Assert.AreEqual(length1, result);
    }

    [TestMethod]
    public void SetSide1_SetsValueOfSide1_Void()
    {
      Rectangle newRectangle = new Rectangle(6, 3, 6, 3);
      int newLength1 = 44;
      newRectangle.Side1 = newLength1;
      Assert.AreEqual(newLength1, newRectangle.Side1);
    }

    [TestMethod]
    public void GetSide2_ReturnsSide2_Int()
    {
      int length2 = 3;
      Rectangle newRectangle = new Rectangle(6, length2, 6, 3);
      int result = newRectangle.Side2;
      Assert.AreEqual(length2, result);
    }

    [TestMethod]
    public void SetSide2_SetsValueOfSide2_Void()
    {
      Rectangle newRectangle = new Rectangle(3, 6, 6, 3);
      int newLength2 = 6;
      newRectangle.Side2 = newLength2;
      Assert.AreEqual(newLength2, newRectangle.Side2);
    }

    [TestMethod]
    public void GetSide3_ReturnsSide3_Int()
    {
      int length3 = 55;
      Rectangle newRectangle = new Rectangle(3, 6, length3, 3);
      int result = newRectangle.GetSide3();
      Assert.AreEqual(length3, result);
    }

    [TestMethod]
    public void SetSide3_SetsValueOfSide3_Void()
    {
      Rectangle newRectangle = new Rectangle(3, 6, 6, 3);
      int newLength3 = 6;
      newRectangle.SetSide3(newLength3);
      Assert.AreEqual(newLength3, newRectangle.GetSide3());
    }

    [TestMethod]
    public void GetSide4_ReturnsSide4_Int()
    {
      int length4 = 60;
      Rectangle newRectangle = new Rectangle(3, 6, 6, length4);
      int result = newRectangle.GetSide4();
      Assert.AreEqual(length4, result);
    }

    [TestMethod]
    public void SetSide4_SetsValueOfSide4_Void()
    {
      Rectangle newRectangle = new Rectangle(3, 3, 6, 6);
      int newLength4 = 6;
      newRectangle.SetSide4(newLength4);
      Assert.AreEqual(newLength4, newRectangle.GetSide4());
    }

    [TestMethod]
    public void CheckType_DeterminesWhenNotARectangle_String()
    {
      Rectangle notARectangle = new Rectangle(3, 3, 6, 7);
      string rectangleType = notARectangle.CheckType();
      Assert.AreEqual("not a rectangle", rectangleType);
    }

    [TestMethod]
    public void CheckType_DeterminesWhenRectangle_String()
    {
      Rectangle rectangle = new Rectangle(3, 6, 3, 6);
      string rectangleType = rectangle.CheckType();
      Assert.AreEqual("rectangle", rectangleType);
    }

    [TestMethod]
    public void CheckType_DeterminesWhenSquare_String()
    {
      Rectangle square = new Rectangle(6, 6, 6, 6);
      string rectangleType = square.CheckType();
      Assert.AreEqual("square", rectangleType);
    }

    [TestMethod]
    public void GetAll_ReturnsAllRectangleInstances_List()
    {
      Rectangle rect1 = new Rectangle(2, 6, 2, 6);
      Rectangle rect2 = new Rectangle(4, 4, 4, 4);
      Rectangle rect3 = new Rectangle(15, 30, 15, 30);
      List<Rectangle> expected = new List<Rectangle> { rect1, rect2, rect3 };
      List<Rectangle> actualResult = Rectangle.GetAll();
      CollectionAssert.AreEqual(expected, actualResult);
    }

    [TestMethod]
    public void ClearAll_DeletesAllRectangleInList_Void()
    {
      Rectangle rect1 = new Rectangle(2, 6, 2, 6);
      Rectangle rect2 = new Rectangle(4, 4, 4, 4);
      Rectangle rect3 = new Rectangle(15, 30, 15, 30);
      List<Rectangle> expected = new List<Rectangle> { };
      Rectangle.ClearAll();
      CollectionAssert.AreEqual(expected, Triangle.GetAll());
    }

  }
}