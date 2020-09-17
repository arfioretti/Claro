using Claro.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Claro.Infra.Data.Contexto
{
    public class Context : DbContext
    {
        public Context() : base("ClaroConn")
        {

        }
        public DbSet<Celular> Celulars { get; set; }

    }

}