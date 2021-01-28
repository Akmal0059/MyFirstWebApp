using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MyFirstWebApp.Models
{
    public class PluginContext : DbContext
    {
        public DbSet<Plugin> Plugins { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
    }

    public class PluginDbInitializer : DropCreateDatabaseAlways<PluginContext>
    {
        protected override void Seed(PluginContext context)
        {
            context.Plugins.Add(new Plugin { ID = 1, Name = "Плагин1", CreateTime = DateTime.Parse("01.01.2021") });
            context.Plugins.Add(new Plugin { ID = 2, Name = "Плагин2", CreateTime = DateTime.Parse("15.12.2020") });
            context.Plugins.Add(new Plugin { ID = 3, Name = "Плагин3", CreateTime = DateTime.Parse("1.12.2020") });

            base.Seed(context);
        }
    }
}