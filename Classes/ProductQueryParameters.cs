using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WatchDog.API.Classes
{
    public class ProductQueryParameters : QueryParameters
    {
        public string Name { get; set; }
        public string Sku { get; set; }
        public decimal? MinPrice { get; set; }
        public decimal? MaxPrice { get; set; }
    }
}
