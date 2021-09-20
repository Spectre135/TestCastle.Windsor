using System;
using System.Collections.Generic;
using System.Threading;

namespace ConsoleApp1
{
  public class DataService : IDataService
  {
    public static string a;
    public static int count;
    public DataService()
    {
      count++;
      Thread.Sleep(30000);
      a = DateTime.Now.Ticks.ToString();    
    }
    public List<string> GetData()
    {
      List<string> c = new List<string>();
      c.Add(this.GetType().Name + "/" + a);
      return c;

    }
  }
}
