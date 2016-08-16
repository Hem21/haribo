using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MyMassSpec.Models
{
    public class MyMassSpecDb : DbContext
    {
        public DbSet<MassSpecModel> MassSpecs { get; set; }
        public DbSet<CommentModel> Comments { get; set; }
    }
}