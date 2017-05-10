﻿namespace SilcoSedonaCustomApi
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using SilcoSedonaCustomApi;

    public partial class SilcoSedona : DbContext
    {
        public SilcoSedona()
            : base("name=SilcoSedona")
        {
        }

        public virtual DbSet<SV_Inspection> SV_Inspection { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SV_Inspection>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<SV_Inspection>()
                .Property(e => e.Inspection_Charge_Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SV_Inspection>()
                .Property(e => e.High_Frequency_Omit)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SV_Inspection>()
                .Property(e => e.Cycle_Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SV_Inspection>()
                .Property(e => e.Terminated_By)
                .IsUnicode(false);

            modelBuilder.Entity<SV_Inspection>()
                .Property(e => e.Exclude_In_Frequency_Omit)
                .IsFixedLength()
                .IsUnicode(false);
        }

        public System.Data.Entity.DbSet<SilcoSedonaCustomApi.AR_Userdef_8> AR_Userdef_8 { get; set; }
    }
}
