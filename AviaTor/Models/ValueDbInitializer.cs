using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace AviaTor.Models
{
    public class ValueDbInitializer : DropCreateDatabaseAlways<ValContext>
    {
        
        protected override void Seed(ValContext db)
        {
            db.Values.Add(new Value { Cashback = 10, Procent = 10, Posetit = 7, Sum = 1500 });
           

            base.Seed(db);
        }
    }
}