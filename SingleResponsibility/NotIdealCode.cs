using SingleResponsibility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility_NotIdealCode
{
    class Database
    {
        public void Connect() 
        {
            // işlemler..
            Console.WriteLine("Veritabanı bağlantısı sağlanmıştır.");
        }

        public void Disconnect() 
        {
            // işlemler..
            Console.WriteLine("Veritabanı bağlantısı kesilmiştir.");
        }

        public string State { get; set; }

        public List<Person> GetPersons()
            // Burada GetPersons metodunun çağrılması, yani Person ile ilgili bir işlem yapılması Single Responsibility prensibine aykırıdır. Test ve bakım maliyetlerini arttırır.
            // Bir nesne, sadece bir nesneye karşı sorumlu olmalıdır. Bu prensibi uygulamak hem test işlemlerinde, hem de projenin yönetilmesinde yararlı olacaktır.
            // Projede bir nesnenin değiştirilmesi gerektiğinde tüm metotlarını baştan yazmak yerine sadece etkilediği durumu ilgilendiren metotların baştan yazılması zaman açısından verimlilik sağlar.
            // Bu yüzden bir yapı, sadece tek bir işi üstlenmelidir.
        {
            return new()
            {
                new(){Name="Hilmi", Surname="Celayir"},
                new(){Name="Mustafa", Surname="Yıldız"},
                new(){Name="Cafer", Surname="Muiddinoğlu"}
            };
        }
    }
}
