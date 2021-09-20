using System;
using System.Collections.Generic;
using System.Threading;

namespace ConsoleApp1
{
  public class DataService2 : IDataService2
  {
    public static string a;
    public static int count;
    public DataService2()
    {
      count++;
      Thread.Sleep(10000);
      a = DateTime.Now.Ticks.ToString();
      
    }
    public List<string> GetData()
    {
      List<string> c = new List<string>();
      c.Add(this.GetType().Name +  "/" + a);
      return c;

    }
  }
}
