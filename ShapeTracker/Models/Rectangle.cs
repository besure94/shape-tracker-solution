namespace ShapeTracker.Models
{
  public class Rectangle
  {
    private int _side1;
    public int Side1
    {
      get { return _side1; }
      set { _side1 = value; }
    }
    public int Side2 { get; set; }
    private int _side3;
    private int _side4;

    public Rectangle(int length1, int length2, int length3, int length4)
    {
      _side1 = length1;
      Side2 = length2;
      _side3 = length3;
      _side4 = length4;
    }

    public int GetSide3()
    {
      return _side3;
    }

    public void SetSide3(int newValue)
    {
      _side3 = newValue;
    }

    public int GetSide4()
    {
      return _side4;
    }

    public void SetSide4(int newValue)
    {
      _side4 = newValue;
    }

    public string CheckType()
    {
      if ((Side1 == Side2) && (_side3 == _side4))
      {
        return "rectangle";
      }
      else
      {
        return "not a rectangle";
      }
    }
  }
}