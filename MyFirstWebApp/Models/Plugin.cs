using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyFirstWebApp.Models
{
    public class Plugin
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public DateTime CreateTime { get; set; }
    }
}