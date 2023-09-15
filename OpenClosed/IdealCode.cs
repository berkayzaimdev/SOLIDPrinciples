using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed.Ideal
{
    class ParaGonderici
    {
        public void Gonder(IBanka banka, int tutar, string hesapNo)
        {
            banka.ParaTransferi(tutar, hesapNo);
        }
    }

    interface IBanka
        // Tüm bankaların ortak bir Interface'ten kalıtım alır. Bu şekilde her bankanın ParaTransferi metodunu kullanması zorunlu hale getirilir.
        // Bu prensip koda Sürdürülebilirlik, Genişletilebilirlik, Yeniden kullanılabilirlik, Esneklik kazandırır.
    {
        bool ParaTransferi(int tutar, string hesapNo);
    }

    class Albaraka : IBanka
    {
        public string HesapNo { get; set; }
        public void ParaGonder(int tutar)
        {
            //...
        }

        public bool ParaTransferi(int tutar, string hesapNo)
        {
            try
            {

                HesapNo = hesapNo;
                ParaGonder(tutar);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
    class Akbank : IBanka
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

        public bool ParaTransferi(int tutar, string hesapNo)
        {
            try
            {
                GonderilecekHesapNo(hesapNo);
                Gonder(tutar);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
    class BerkayBank : IBanka
    {
        public bool ParaTransferi(int tutar, string hesapNo)
        {
            throw new NotImplementedException();
        }
    }
}
