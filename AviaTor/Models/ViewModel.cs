using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AviaTor.Models.ViewModels
{
    public class AdvViewModel
    {
        public int Id { get; set; }

        public int Cashback { get; set; }

        public int Procent { get; set; }

        public int Posetit { get; set; }

        public int Sum { get; set; }

        public List<Value> Values { get; set; }

    }
}