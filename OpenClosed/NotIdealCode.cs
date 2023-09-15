using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed.NotIdeal
{
    class ParaGonderici
    {
        public void Gonder(int tutar)
        {
            //Akbank akbank = new();
            //akbank.HesapNo = "...";
            //akbank.ParaGonder(tutar);
            Albaraka albaraka = new();
            albaraka.GonderilecekHesapNo("123");
            albaraka.Gonder(tutar);
        }
    }

    // Para gönderme metodunu değiştirmek istediğimizde, mesela ekleme esnasında doğrulama için CAPTCHA eklemek istediğimizde tüm metotları değiştirmemiz gerekir.
    // Bu durum hem gereksiz kod kalabalığı, hem de maliyet ve verimlilik açısından zarar oluşturacaktır.
    // Bu nedenle tüm bankaların ortak kalıtım aldığı bir yapı, ve o yapıdan aldığı ortak metot oluşturmalıyız.
    // Bu yapı da Interface'e karşılık geliyor.

    class Albaraka
    {
        string _hesapNo;
        public void GonderilecekHesapNo(string hesapNo)
        {
            //...
        }
        public void Gonder(int tutar)
        {
            //...
        }
    }

    class Akbank
    {
        public string HesapNo { get; set; }
        public void ParaGonder(int tutar)
        {
            //...
        }
    }
}
