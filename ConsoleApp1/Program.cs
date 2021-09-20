using System;
using System.Linq;
using System.Threading;
using Castle.MicroKernel.Registration;
using Castle.Windsor;

namespace ConsoleApp1
{
  public class Test
  {
    //private IDependency1 object1;
    //private IDependency2 object2;
    static WindsorContainer container = new WindsorContainer();
    static void Main(string[] args)
    {
      container.Register(Component.For<IDataService>().ImplementedBy<DataService>().LifestyleSingleton());
      container.Register(Component.For<IDataService2>().ImplementedBy<DataService2>().LifestyleSingleton());
      //container.Register(Castle.MicroKernel.Registration.Component.For<IDependency2>().ImplementedBy<Dependency2>().LifestyleSingleton());

      for (int i = 0; i < 200; i++)
      {
        Thread t = new Thread(Init);
        t.Start();
      }
    }

    public void DoSomething()
    {
      //object1.SomeObject = "Hello World";
      //object2.SomeOtherObject = "Hello Mars";
    }

    private static void Init()
    {
      var x = container.Resolve<IDataService>();
      var y = container.Resolve<IDataService2>();
      //DataService x = new DataService();
      Console.WriteLine(String.Format("Instance:{0} Count:{1}",x.GetData().FirstOrDefault(),DataService.count));
      Console.WriteLine(String.Format("Instance:{0} Count:{1}", y.GetData().FirstOrDefault(), DataService2.count));
    }
  }
}
