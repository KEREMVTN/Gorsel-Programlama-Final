﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Görsel_Vize
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class GörselEntities : DbContext
    {
        public GörselEntities()
            : base("name=GörselEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<OkulYönetimi> OkulYönetimi { get; set; }
        public virtual DbSet<ÖDers> ÖDers { get; set; }
        public virtual DbSet<Öğrenci> Öğrenci { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<YönetimDers> YönetimDers { get; set; }
    }
}
