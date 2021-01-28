using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyFirstWebApp.Models
{
    public class Purchase
    {
        public int PurchaseId { get; set; }
        public string Name { get; set; }
        public string EMail { get; set; }
        public int PluginId { get; set; }
        public DateTime Date { get; set; }

    }
}