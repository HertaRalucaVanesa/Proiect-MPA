using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Proiect_MPA.Models;

namespace Proiect_MPA.Data
{
    public class DbInitializer
    {
        public static void Initialize(LibraryContext context)
        {
            context.Database.EnsureCreated();
            if (context.Phones.Any())
            {
                return; // BD a fost creata anterior
            }
            var phones = new Phone[]
            {
 new Phone{Brand="Samsung",Model="Galaxy S10 Plus",Price=Decimal.Parse("2200")},
 new Phone{Brand="Oppo",Model="Reno 5 5G",Price=Decimal.Parse("1800")},
 new Phone{Brand="Apple",Model="Iphone 11 Pro Max",Price=Decimal.Parse("4700")}
            };
            foreach (Phone s in phones)
            {
                context.Phones.Add(s);
            }
            context.SaveChanges();
            var customers = new Customer[]
            {

 new Customer{CustomerID=150,Name="Pop Ana",BirthDate=DateTime.Parse("1999-12-10")},
 new Customer{CustomerID=145,Name="Bogdan Cristi",BirthDate=DateTime.Parse("1992-06-11")},

 };
            foreach (Customer c in customers)
            {
                context.Customers.Add(c);
            }
            context.SaveChanges();
            var orders = new Order[]
            {
 new Order{PhoneID=1,CustomerID=150},
 new Order{PhoneID=3,CustomerID=145},
 new Order{PhoneID=1,CustomerID=145},
 new Order{PhoneID=2,CustomerID=150},
            };
            foreach (Order e in orders)
            {
                context.Orders.Add(e);
            }
            context.SaveChanges();
        }
    }
}
