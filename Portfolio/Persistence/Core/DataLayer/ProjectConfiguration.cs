using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using Portfolio.Persistence.Core.Models;

namespace Portfolio.Persistence.Core.DataLayer
{
    public class ProjectConfiguration : EntityTypeConfiguration<Project>
    {
        public ProjectConfiguration()
        {
            HasRequired(p => p.User)
                .WithMany(au => au.Projects)
                .WillCascadeOnDelete(false);

        }
    }
}