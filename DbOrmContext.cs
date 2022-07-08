﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MySql.Data.EntityFramework;
using TFLWebApp.Models;

namespace TFLWebApp.DAL
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class DbOrmContext : DbContext
    {
        public DbSet<Product> Product10 { get; set; }

        public DbOrmContext() : base("WebAppCon")
        {

        }
    }
}