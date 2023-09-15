using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion.NotIdeal
{
    // Buradaki temel problem, yüksek seviyeli sınıfın düşük seviyeli sınıflara bağımlı olmasıdır.
    // Dependency Inversion Prensibi, bu soruna "Yüksek seviyeli sınıflar, düşük seviyeli sınıflara bağlı olmamalı, her ikisi de soyut kavramlara bağlı olmalıdır" görüşü ile çözüm getirmektedir.
    // Sınıfları ayrık bir şekilde tanımlamak yerine soyutlama yardımıyla ortak noktalarını bir kümeye alabiliriz. Bu kümeyi Interface yardımıyla oluşturabiliriz.

    // Soyutlamalar ayrıntılara bağlı olmamalıdır. Detaylar soyutlamalara bağlı olmalıdır.
    // Yani alt sınıflarda yapılan bir değişiklik üst sınıfları etkilememelidir.

    public class Ferrari
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

    public class Mercedes
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
        public void Run()
        {
            var ferrari = new Ferrari();
            ferrari.Run();

            var mercedes = new Mercedes();
            mercedes.Run();
        }

        public void Stop()
        {
            var ferrari = new Ferrari();
            ferrari.Stop();

            var mercedes = new Mercedes();
            mercedes.Stop();
        }
    }
}