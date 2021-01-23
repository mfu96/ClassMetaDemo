using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetaDemo
{
    class CustomerManager
    {
        public void Information(CustomerInformation customer)
        {
            Console.WriteLine("Müşterinin Kimliği: " +customer.ID);
            Console.WriteLine("Müşterinin Adı Soyadı: " + customer.Name +" "+customer.Lastname);
            Console.WriteLine("Müşterinin Adresi: "+ customer.Address);
            Console.WriteLine("Müşterinin Bilgileri Yukarda Gösterilmiştir: ");
        }

        public void Added()
        {
            Console.WriteLine("Aşağıdaki Biligileri Doldurunuz");
            Console.WriteLine("Zorunlu Alanlar *");
            Console.WriteLine("*Adı: ");
            string name = Console.ReadLine();
            Console.WriteLine("*Soyadı: ");
            string lastname = Console.ReadLine();
            Console.WriteLine("*Adresi: ");
            string Address = Console.ReadLine();
            Console.WriteLine($"Teşekkürler müşteri başarılı bir şekilde ekelendi: {name} {lastname} {Address}");
        }
        public void Deleted()
        {
            Console.WriteLine("Silmek İstediğiniz Müşteirin ID'sini doldurunuz");
            Console.WriteLine("ID: ");
            string ID = Console.ReadLine();
           
            Console.WriteLine($"Müşteri başarılı bir şekilde silindi: {ID}" );


        }

    }
}
