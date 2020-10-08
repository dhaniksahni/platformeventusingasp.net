using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Diagnostics.Eventing.Reader;

namespace salesforceCodexStore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var client = SalesforceClient.CreateClient();
            client.Login();
            var products = client.Query("Select Id,Name,UnitPrice__c, Quantity__c,IsStockAvailable__c,Image__c from Product__c where IsStockAvailable__c=true");
            var prds = JsonConvert.DeserializeObject<Models.Product>(products);
            return View(prds);
        }

        public IActionResult Buy(string id, string quantity,string name,string custId)
        {
            long quan = long.Parse(quantity.Replace(".0",""));
            var client = SalesforceClient.CreateClient();
            client.Login();
            var products = client.addMessage(id,((Int32)quan- 1),name,custId);
            return RedirectToAction("Index");
        }

        public IActionResult Product(string id, string quantity,string name,string image)
        {
            Models.Prd prd = new Models.Prd();
            prd.Id = id;
            prd.Image__c = image;
            prd.Quantity__c = quantity;
            prd.Name = name;
            return View(prd);
        }
    }
}

