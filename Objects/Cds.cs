using System.Collections.Generic;

namespace Cds.Objects
{
  public class Cd
  {
    private static List<Cd> _instances = new List<Cd> {};
    private string _name;
    private int _id;
    private string _artists;

    public Cd(string cdName, string artists)
    {
      _name = cdName;
      _instances.Add(this);
      _id = _instances.Count;
      _artists = artists;
    }

    public string GetCdName()
    {
      return _name;
    }
    public void SetCdName(string name)
    {
      _name = name;
    }
    public string GetArtists()
    {
      return _artists;
    }
    public int GetId()
    {
      return _id;
    }
    public void SetArtists(string artists)
    {
      _artists =artists;
    }
    public static List<Cd> GetAll()
    {
      return _instances;
    }
    public static void Clear()
    {
      _instances.Clear();
    }
  }
}
