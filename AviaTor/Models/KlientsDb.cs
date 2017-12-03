using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace AviaTor.Models
{
    public class KlientsDb : DropCreateDatabaseAlways<KlienContext>
    {

        protected override void Seed(KlienContext db)
        {
            db.Clienti.Add(new Klients { Name = "Alex", Phone = "79996669966", Bonus = 20 });
            db.Clienti.Add(new Klients { Name = "Shrek", Phone = "27051703", Bonus = 1703 });
            db.Clienti.Add(new Klients { Name = "Devil", Phone = "88005553535", Bonus = 56 });
            db.Clienti.Add(new Klients { Name = "Korabel", Phone = "89530000000", Bonus = 77 });
            db.Clienti.Add(new Klients { Name = "Patrick", Phone = "88888888888", Bonus = 88 });
            db.Clienti.Add(new Klients { Name = "Deus", Phone = "10961272109", Bonus = 96 });
            db.Clienti.Add(new Klients { Name = "Wult", Phone = "12721096127", Bonus = 72 });
            base.Seed(db);
        }

    }
}