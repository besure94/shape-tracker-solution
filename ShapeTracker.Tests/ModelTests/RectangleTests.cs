using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeTracker.Models;
using System.Collections.Generic;
using System;

namespace ShapeTracker.Tests
{
  [TestClass]
  public class RectangleTests
  {

    [TestMethod]
    public void RectangleConstructor_CreatesInstanceOfRectangle_Rectangle()
    {
      Rectangle newRectangle = new Rectangle(6, 3, 6);
      Assert.AreEqual(typeof(Rectangle), newRectangle.GetType());
    }

    [TestMethod]
    public void GetSide1_ReturnsSide1_Int()
    {
      int length1 = 3;
      Rectangle newRectangle = new Rectangle(length1, 6, 3);
      int result = newRectangle.Side1;
      Assert.AreEqual(length1, result);
    }

    [TestMethod]
    public void SetSide1_SetsValueOfSide1_Void()
    {
      Rectangle newRectangle = new Rectangle(6, 3, 6);
      int newLength1 = 44;
      newRectangle.Side1 = newLength1;
      Assert.AreEqual(newLength1, newRectangle.Side1);
    }

    [TestMethod]
    public void GetSide2_ReturnsSide2_Int()
    {
      int length2 = 3;
      Rectangle newRectangle = new Rectangle(6, length2, 6);
      int result = newRectangle.Side2;
      Assert.AreEqual(length2, result);
    }

    [TestMethod]
    public void SetSide2_SetsValueOfSide2_Void()
    {
      Rectangle newRectangle = new Rectangle(3, 6, 6);
      int newLength2 = 6;
      newRectangle.Side2 = newLength2;
      Assert.AreEqual(newLength2, newRectangle.Side2);
    }

    [TestMethod]
    public void GetSide3_ReturnsSide3_Int()
    {
      int length3 = 55;
      Rectangle newRectangle = new Rectangle(3, 6, length3);
      int result = newRectangle.GetSide3();
      Assert.AreEqual(length3, result);
    }

    [TestMethod]
    public void SetSide3_SetsValueOfSide3_Void()
    {
      Rectangle newRectangle = new Rectangle(3, 6, 6);
      int newLength3 = 6;
      newRectangle.SetSide3(newLength3);
      Assert.AreEqual(newLength3, newRectangle.GetSide3());
    }

  }
}