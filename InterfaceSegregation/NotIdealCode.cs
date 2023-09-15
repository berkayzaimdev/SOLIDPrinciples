using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation.NotIdeal
{
    interface IPrinter
    {
        void Print();
        void Scan();
        void Fax();
        void PrintDuplex();
    }

    // Liskov Substitution Prensibi ile önemli ölçüde benzerlik gösterir.
    // Aralarındaki neredeyse tek fark, LSP'nin ana CLASS'tan kaynaklanan bir problem olması. Interface Segregation Prensibi ise Interface'ler ile ilgilenir.

    class HPPrinter : IPrinter
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
    class SamsungPrinter : IPrinter
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
            => throw new NotSupportedException();

        public void Scan()
            => throw new NotSupportedException();
    }
    class LexmarkPrinter : IPrinter
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
            => throw new NotSupportedException();

        public void Scan()
        {
            //... Scan işlemleri ...
        }
    }
}
