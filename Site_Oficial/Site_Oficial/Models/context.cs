using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Site_Oficial.Models
{
    public class context: DbContext
    {
        DbSet<cliente> clientes { get; set; }
    }
}