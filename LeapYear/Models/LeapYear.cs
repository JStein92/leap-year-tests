namespace LeapYear.Models
{
  public class LeapYearConverter
  {
    private int _year;
    public LeapYearConverter(int year)
    {
      _year = year;
    }
    public int GetYear()
    {
      return _year;
    }
    public bool IsLeapYear()
    {
      if (_year % 400 == 0)
      {
        return true;
      }
      else if (_year % 100 == 0)
      {
        return false;
      }
      else
      {
        return _year % 4 == 0;
      }

    }

  }
}
