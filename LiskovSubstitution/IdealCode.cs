using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitution
{
    abstract class Cloud
    {
        public abstract void MachineLearning();
    }
    // MachineLearning() metodu bütün Child sınıflarda kullanıldığı için, hepsinde ortak olan Cloud sınıfını oluşturduk.

    interface ITranslatable
    {
        void Translate();
    }
    // Translate() metodu, daha az sayıda Child sınıfta kullanıldığı için, bunu bir Interface'de asıl sıınıfa haricen dahil ettik.

    // Bu prensibe gerçek hayattan örnek verecek olursak, hayvanlar aleminden örnek verebiliriz.
    // Kedi yürüyebilir. Timsah hem yürüyebilir, hem de yüzebilir. Ördek hem yürüyebilir, hem yüzebilir, hem de uçabilir.
    // Bu bağlamda bütün hareket şekillerini bir sınıfta tanımlamak ve override etmek yerine, ana bir sınıfta hepsinde ortak olan yürüme hareketini tanımlayıp, yüzme ve uçmayı ise harici bir Interface'te tanımlayabiliriz.

    class AWS : Cloud, ITranslatable
    {
        public void Translate()
           => Console.WriteLine("AWS Translate");
        override public void MachineLearning()
            => Console.WriteLine("AWS Machine Learning");
    }

    class Azure : Cloud
    {
        override public void MachineLearning()
            => Console.WriteLine("Azure Machine Learning");
    }

    class Google : Cloud, ITranslatable
    {
        public void Translate()
           => Console.WriteLine("Google Translate");

        override public void MachineLearning()
            => Console.WriteLine("Google Machine Learning");
    }
}
