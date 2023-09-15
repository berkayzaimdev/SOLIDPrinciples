using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitution.NotIdeal
{
    abstract class Cloud
    {
        public abstract void Translate(); // Bu metot tüm sınıflarda sağlanmamaktadır
        public abstract void MachineLearning(); // Bu metot tüm sınıflarda sağlanmaktadır
    }

    // Bu prensipteki ana düşüncemiz; eğer kalıtım alınan bir sınıf veya Interface varsa, bu Parent nesnedeki tüm metotlar Child nesnelerde kullanılmalıdır.
    // Eğer o metotları boş bırakırsak yahut hata fırlatırsak program bir noktada sıkışacak, hata verecektir.

    class AWS : Cloud
    {
        override public void Translate()
            => Console.WriteLine("AWS Translate");
        override public void MachineLearning()
            => Console.WriteLine("AWS Machine Learning");
    }

    class Azure : Cloud
    {
        override public void Translate()
            => throw new NotImplementedException();

        override public void MachineLearning()
            => Console.WriteLine("Azure Machine Learning");
    }

    class Google : Cloud
    {
        override public void Translate()
            => Console.WriteLine("Google Translate");

        override public void MachineLearning()
            => Console.WriteLine("Google Machine Learning");
    }
}
