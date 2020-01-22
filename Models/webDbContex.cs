using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Website_Code_333.Models
{
    public class webDbContex: DbContext
    {
        public DbSet<CatProfile> CatProfiles { get; set; }
    }
}