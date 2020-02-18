using P03_SalesDatabase.Data;
using Microsoft.Extensions.DependencyInjection;

namespace P03_SalesDatabase
{
    public class StartUp
    {
        static ServiceProvider Main(string[] args)
        {
            SalesContext salesContext = new SalesContext();

            using (salesContext)
            {
                //..
            }

            ServiceCollection services = new ServiceCollection();

            // services.AddSingleton();

            ServiceProvider sp = services.BuildServiceProvider();

            return sp;
        }
    }
}
