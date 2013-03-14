using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GitMVC4Test.Models
{
    public class MvcDb : DbContext
    {
        public MvcDb(): base("name=DefaultConnection")
        {
        }

        public DbSet<UserProfile> UserProfiles { get; set; }
    }
}