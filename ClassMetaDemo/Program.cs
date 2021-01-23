using System;

namespace ClassMetaDemo
{
    class Program
    {
        static void Main(string[] args)
        {
           
                CustomerInformation customer1 = new CustomerInformation();
                customer1.ID = 33;
                customer1.Name = "Muhammed Furkan";
                customer1.Lastname = "USLU";
                customer1.Address = "Van";

                CustomerInformation customer2 = new CustomerInformation();
                customer2.ID = 133;
                customer2.Name = "Faruk";
                customer2.Lastname = "Gürbüz";
                customer2.Address = "Ankara";


                CustomerInformation customer3 = new CustomerInformation();
                customer3.ID = 333;
                customer3.Name = "Şinasi";
                customer3.Lastname = "Taşyakan";
                customer3.Address = "Hatay";

                CustomerInformation[] customers = new CustomerInformation[] {customer1, customer2, customer3};

                CustomerManager customerManager = new CustomerManager();
                customerManager.Information(customer1);
                Console.WriteLine("");
                customerManager.Information(customer3);

            customerManager.Added();
                customerManager.Deleted();

        }
    }
}
