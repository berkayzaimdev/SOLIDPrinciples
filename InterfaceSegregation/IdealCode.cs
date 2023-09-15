using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation
{
    interface IPrint
    {
        void Print();
    }
    interface IScan
    {
        void Scan();
    }
    interface IFax
    {
        void Fax();
    }
    interface IPrintDuplex
    {
        void PrintDuplex();
    }

    // Bu prensibe gerçek hayattan örnek verecek olursak, yine hayvanlar aleminden örnek verebiliriz.
    // Kedi yürüyebilir. Timsah hem yürüyebilir, hem de yüzebilir. Ördek hem yürüyebilir, hem yüzebilir, hem de uçabilir. Balık ise sadece yüzebilir
    // Bu bağlamda bütün hareket şekillerini tek bir Interface'te toplamak yerine hareketleri ayrı ayrı Interface'lerde tanımlayabiliriz.
    // Bu sayede her bir sınıf sadece kendisi ile ilgili olan Interface'leri implemente eder.

    class HPPrinter : IPrint, IScan, IFax, IPrintDuplex
    {
        public void Fax()
        {
            //... Fax işlemleri ...
        }

        public void Print()
        {
            //... Print işlemleri ...
        }

        public void PrintDuplex()
        {
            //... Print Duplex işlemleri ...
        }

        public void Scan()
        {
            //... Scan işlemleri ...
        }
    }
    class SamsungPrinter : IPrint, IFax
    {
        public void Fax()
        {
            //... Fax işlemleri ...
        }

        public void Print()
        {
            //... Print işlemleri ...
        }
    }
    class LexmarkPrinter : IFax, IPrint, IScan
    {
        public void Fax()
        {
            //... Fax işlemleri ...
        }

        public void Print()
        {
            //... Print işlemleri ...
        }

        public void Scan()
        {
            //... Scan işlemleri ...
        }
    }
}
