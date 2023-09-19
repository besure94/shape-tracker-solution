using System;
using ShapeTracker.Models;
using System.Collections.Generic;

namespace ShapeTracker
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
      Console.WriteLine("Welcome to the Shape Tracker app!");
      Console.WriteLine("What type of shape would you like to calculate?");
      Console.WriteLine("Please enter either 'triangle' or 'rectangle'.");
      string inputtedShape = Console.ReadLine();
      if (inputtedShape == "triangle" || inputtedShape == "Triangle")
      {
        Console.WriteLine("We'll calculate what type of triangle you have based off of the lengths of the triangle's 3 sides.");
        Console.WriteLine("Please enter a number:");
        string stringNumber1 = Console.ReadLine();
        Console.WriteLine("Enter another number:");
        string stringNumber2 = Console.ReadLine();
        Console.WriteLine("Enter a third number:");
        string stringNumber3 = Console.ReadLine();
        try
        {
          int length1 = int.Parse(stringNumber1);
          int length2 = int.Parse(stringNumber2);
          int length3 = int.Parse(stringNumber3);
          Triangle tri = new Triangle(length1, length2, length3);
          ConfirmOrEditTriangle(tri);
          Triangle.ClearAll();
        }
        catch
        {
          Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
          Console.WriteLine("ERROR: Please only enter in numbers! Special symbols and alphabetic characters will not be accepted.");
          Console.WriteLine("Please try again...");
          Main();
        }
      }
      else if (inputtedShape == "rectangle" || inputtedShape == "Rectangle")
      {
        Console.WriteLine("We'll calculate the area of a rectangle based off of the lengths of the rectangle's 2 sides.");
        Console.WriteLine("Please enter a number:");
        string userNumber1 = Console.ReadLine();
        Console.WriteLine("Enter another number:");
        string userNumber2 = Console.ReadLine();
        try
        {
          int rectangleLength1 = int.Parse(userNumber1);
          int rectangleLength2 = int.Parse(userNumber2);
          Rectangle rect = new Rectangle(rectangleLength1, rectangleLength2);
          ConfirmOrEditRectangle(rect);
          Rectangle.ClearAll();
        }
        catch
        {
          Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
          Console.WriteLine("ERROR: Please only enter in numbers! Special symbols and alphabetic characters will not be accepted.");
          Console.WriteLine("Please try again...");
          Main();
        }
      }
    }

    static void ConfirmOrEditTriangle(Triangle tri)
    {
      Console.WriteLine("Please confirm that you entered in your triangle correctly:");
      Console.WriteLine($"Side 1 has a length of {tri.Side1}.");
      Console.WriteLine($"Side 2 has a length of {tri.Side2}.");
      Console.WriteLine($"Side 3 has a length of {tri.GetSide3()}.");
      Console.WriteLine("Is that correct? Enter 'yes' to proceed, or 'no' to re-enter the triangle's sides.");
      string userInput = Console.ReadLine();
      if (userInput == "yes")
      {
        CheckTriangleType(tri);
      }
      else
      {
        Console.WriteLine("Let's fix your triangle. Please enter the 3 sides again!");
        Console.WriteLine("Please enter a number:");
        string stringNumber1 = Console.ReadLine();
        Console.WriteLine("Enter another number:");
        string stringNumber2 = Console.ReadLine();
        Console.WriteLine("Enter a third number:");
        string stringNumber3 = Console.ReadLine();
        tri.Side1 = int.Parse(stringNumber1);
        tri.Side2 = int.Parse(stringNumber2);
        tri.SetSide3(int.Parse(stringNumber3));
        ConfirmOrEditTriangle(tri);
      }
    }

    static void CheckTriangleType(Triangle tri)
    {
      string result = tri.CheckType();
      Console.WriteLine("-----------------------------------------");
      Console.WriteLine("Your result is: " + result + ".");
      Console.WriteLine("-----------------------------------------");
      Console.WriteLine("What's next?");
      Console.WriteLine("Would you like to check a new triangle (new)?");
      Console.WriteLine("Or would you like to see a list of all triangles you have created (list) ?");
      Console.WriteLine("Please enter 'new' to check the type of a new triangle.");
      Console.WriteLine("You can also enter 'list' to see a list of all triangles you have created.");
      string userResponse = Console.ReadLine();
      if (userResponse == "new" || userResponse == "New")
      {
        Main();
      }
      else if (userResponse == "list" || userResponse == "List")
      {
        Console.WriteLine("Here is a list of all the triangles you have created!");
        Console.WriteLine("-----------------------------------------");
        List<Triangle> allTriangles = Triangle.GetAll();
        foreach (Triangle triangle in allTriangles)
        {
          Console.WriteLine($"You have a {triangle.CheckType()}.");
        }
        Console.WriteLine("-----------------------------------------");
        Console.WriteLine("Please enter 'clear' if you would like to remove all triangles and start over.");
        Console.WriteLine("Otherwise, enter 'continue' to continue creating more triangles.");
        string userInput = Console.ReadLine();
        if (userInput == "clear" || userInput == "Clear")
        {
          Triangle.ClearAll();
          Console.WriteLine("You have no triangles!");
          Main();
        }
        else if (userInput == "continue" || userInput == "Continue")
        {
          Main();
        }
        Main();
      }
      else
      {
        Console.WriteLine("Goodbye!");
      }
    }

    static void ConfirmOrEditRectangle(Rectangle rect)
    {
      Console.WriteLine("Please confirm that you entered in your rectangle correctly:");
      Console.WriteLine($"Side 1 has a length of {rect.Side1}.");
      Console.WriteLine($"Side 2 has a length of {rect.Side2}.");
      Console.WriteLine("Is that correct? Enter 'yes' to proceed, or 'no' to re-enter the rectangle's sides.");
      string userString = Console.ReadLine();
      if (userString == "yes" || userString == "Yes")
      {
        CheckRectangleType(rect);
      }
      else
      {
        Console.WriteLine("Let's fix your rectangle. Please enter the 2 sides again!");
        string userNumber1 = Console.ReadLine();
        Console.WriteLine("Enter another number:");
        string userNumber2 = Console.ReadLine();
        rect.Side1 = int.Parse(userNumber1);
        rect.Side2 = int.Parse(userNumber2);
        ConfirmOrEditRectangle(rect);
      }
    }

    static void CheckRectangleType(Rectangle rect)
    {
      string rectangleResult = rect.CheckType();
      int areaOfRectangle = rect.GetArea();
      Console.WriteLine("-----------------------------------------");
      Console.WriteLine("Your result is: " + rectangleResult + ".");
      Console.WriteLine("The area of your rectangle is: " + areaOfRectangle + ".");
      Console.WriteLine("-----------------------------------------");
      Console.WriteLine("What's next?");
      Console.WriteLine("Would you like to check and get the area of a new rectangle (new)?");
      Console.WriteLine("Or would you like to see a list of all rectangles you have created (list) ?");
      Console.WriteLine("Please enter 'new' to check the type and get the area of a new rectangle, or  check a new triangle.");
      Console.WriteLine("You can also enter 'list' to see a list of all rectangles you have created.");
      string inputtedUserString = Console.ReadLine();
      if (inputtedUserString == "new" || inputtedUserString == "New")
      {
        Main();
      }
      else if (inputtedUserString == "list" || inputtedUserString == "List")
      {
        Console.WriteLine("Here is a list of all the rectangles you have created!");
        Console.WriteLine("-----------------------------------------");
        List<Rectangle> allRectangles = Rectangle.GetAll();
        foreach (Rectangle rectangle in allRectangles)
        {
          Console.WriteLine($"You have a {rectangle.CheckType()}.");
        }
        Console.WriteLine("-----------------------------------------");
        Console.WriteLine("Please enter 'clear' if you would like to remove all rectangles and start over.");
        Console.WriteLine("Otherwise, enter 'continue' to continue creating more rectangles.");
        string userDecision = Console.ReadLine();
        if (userDecision == "clear" || userDecision == "Clear")
        {
          Rectangle.ClearAll();
          Console.WriteLine("You have no rectangles!");
          Main();
        }
        else if (userDecision == "continue" || userDecision == "Continue")
        {
          Main();
        }
        Main();
      }
      else
      {
        Console.WriteLine("Goodbye!");
      }
    }

  }
}