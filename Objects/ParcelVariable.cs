namespace ParcelTracker.Objects
{
  public class ParcelVariables
  {
    private int _height;
    private int _weight;
    private int _length;
    private int _width;

    public int GetHeight()
    {
      return _height;
    }
    public void SetHeight(int height)
    {
      _height = height;
    }

    public int GetWeight()
    {
      return _weight;
    }
    public void SetWeight(int weight)
    {
      _weight = weight;
    }
    public int GetLength()
    {
      return _length;
    }
    public void SetLength(int length)
    {
      _length = length;
    }
    public int GetWidth()
    {
      return _width;
    }
    public void SetWidth(int width)
    {
      _width = width;
    }

    public int CalculateVolume()
    {
      return _height * _length * _width;
    }

    public int CalculateCost()
    {
      return _height + _length * _weight;
    }


  }
}
