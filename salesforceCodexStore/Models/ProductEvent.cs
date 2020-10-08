using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace salesforceCodexStore.Models
{
    public class ProductEvent : EventBase
    {
        public ProductEvent()
        {
            Items = new List<ProductEvent>();
        }

        public List<ProductEvent> Items { get; set; }

        public string ProductID__c { get; set; }
        public string Quantity__c { get; set; }
        public string ProductName__c { get; set; }
        public string CustomerId__c { get; set; }
    }
}
