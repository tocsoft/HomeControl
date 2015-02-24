using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace HomeControl.Core.DB
{
    public class HomeControlDB : DbContext
    {
        public HomeControlDB()
        {
        }

        public DbSet<HomeControl.Models.Home> Homes { get; set; }
    }
}
