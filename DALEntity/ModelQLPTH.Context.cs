﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DALEntity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class QLPTHEntities : DbContext
    {
        public QLPTHEntities()
            : base("name=QLPTHEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<account> accounts { get; set; }
        public virtual DbSet<computer> computers { get; set; }
        public virtual DbSet<permision> permisions { get; set; }
        public virtual DbSet<room> rooms { get; set; }
        public virtual DbSet<schedule_detail> schedule_detail { get; set; }
        public virtual DbSet<status> status { get; set; }
        public virtual DbSet<subject> subjects { get; set; }
        public virtual DbSet<teacher> teachers { get; set; }
    }
}