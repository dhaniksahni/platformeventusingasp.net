using System;
using System.Collections.Generic;

namespace salesforceCodexStore.Models
{
    public class Product
    {
        public Boolean done { get; set; }
        public Int16 totalSize { get; set; }
        public List<Prd> records { get; set; }
    }
    public class Prd
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Quantity__c { get; set; }
        public string UnitPrice__c { get; set; }
        public string Discount__c { get; set; }
        public string Image__c { get; set; }
        public Boolean IsStockAvailable__c { get; set; }
        public string ProductName__c { get; set; }
        public string CustomerId__c { get; set; }
    }

    public class PlatformEvent
    {
        public string ProductID__c { get; set; }
        public string Quantity__c { get; set; }
        public string ProductName__c { get; set; }
        public string CustomerId__c { get; set; }
    }
}
