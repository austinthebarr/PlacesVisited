using System;
using System.Collections.Generic;

namespace PlacesVisited.Models
{
  public class Places
  {
    private string _location;
    private string _dates;
    private string _pictureURL;
    private static List<Places> _instances = new List<Places> {};

    public Places(string location, string dates, string pictureURL)
    {
      _location = location;
      _dates = dates;
      _pictureURL = pictureURL;
      _instances.Add(this);
    }

    public void SetLocation(string newLocation)
    {
        _location = newLocation;
    }
    public string GetLocation()
    {
      return _location;
    }

    public void SetDates(string newDates)
    {
        _dates = newDates;
    }
    public string GetDates()
    {
      return _dates;
    }

    public void SetPicture(string newPicture)
    {
        _pictureURL = newPicture;
    }
    public string GetPicture()
    {
      return _pictureURL;
    }

    public static List<Places> GetAll()
    {
      return _instances;
    }
  }
}
