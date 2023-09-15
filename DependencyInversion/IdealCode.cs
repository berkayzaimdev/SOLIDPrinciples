using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion.Ideal
{
    //Mercedes ve Ferrari markalı otomobil sınıflarında; IAutomobile arayüzü kullanarak AutomobileService sınıfının constructor’ ında enjekte ettik
    //ve bu şekilde geliştirmemizi prensibimize uygun hale getirmiş olduk.
    public interface IAutomobile
    {
        public void Run();
        public void Stop();
    }

    public class Ferrari : IAutomobile
    {
        public void Run()
        {
            Console.WriteLine("Ferrari çalıştırıldı");
        }

        public void Stop()
        {
            Console.WriteLine("Ferrari durduruldu.");
        }
    }

    public class Mercedes : IAutomobile
    {
        public void Run()
        {
            Console.WriteLine("Mercedes çalıştırıldı");
        }

        public void Stop()
        {
            Console.WriteLine("Mercedes durduruldu.");
        }
    }

    public class AutomobileService
    {
        private readonly IAutomobile automobile;

        public AutomobileService(IAutomobile automobile)
        {
            this.automobile = automobile;
        }

        public void Start()
        {
            automobile.Run();
        }

        public void Stop()
        {
            automobile.Stop();
        }
    }
}