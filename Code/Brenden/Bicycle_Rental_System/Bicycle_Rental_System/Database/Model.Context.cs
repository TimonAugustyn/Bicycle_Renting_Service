﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Bicycle_Rental_System.Database
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DatabaseEntities : DbContext
    {
        public DatabaseEntities()
            : base("name=DatabaseEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<bicycle> bicycles { get; set; }
        public virtual DbSet<bmodel> bmodels { get; set; }
        public virtual DbSet<employee> employees { get; set; }
        public virtual DbSet<rental> rentals { get; set; }
        public virtual DbSet<role> roles { get; set; }
        public virtual DbSet<student> students { get; set; }
    }
}
