using SingleResponsibility;

namespace SingleResponsibility_IdealCode
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
    }

    class PersonService 
        // Tek Sorumluluk Prensibine uyması için Person ile ilgili olan metodu, PersonService adında yeni bir sınıf tanımlayarak Database sınıfından ayırdık.
        // Böylece GetPersons() metodunu değiştirmemiz gereken durumlarda tüm Database sınıfı yerine sadece PersonService sınıfını değiştirerek sorunu çözebileceğiz.
    {
        public List<Person> GetPersons()
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
