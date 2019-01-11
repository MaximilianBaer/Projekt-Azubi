using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Domain;
using Domain.Acces;
using System.Data.Entity;

namespace mvc
{
    public class CreateDatabase
    {
        public static void test()
        {
            var data = new DatabaseContext();
            data.Database.Delete();
            data.Database.Create();
            

            var sur = new Survey() {ID = new Guid(), name = "test" };

            data.Entry(sur);
            data.SaveChanges();
            
        }
    }
}