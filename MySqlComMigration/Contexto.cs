﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace MySqlComMigration
{
    public class Contexto : DbContext
    {
        public Contexto()
                     : base("Contexto")
        {

        }

        public DbSet<Contato> Contato { get; set; }

    }
}