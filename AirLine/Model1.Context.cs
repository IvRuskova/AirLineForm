﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AirLine
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class AirLineDbEntities1 : DbContext
    {
        public AirLineDbEntities1()
            : base("name=AirLineDbEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<Cust_Details> Cust_Details { get; set; }
        public virtual DbSet<Flight_Info> Flight_Info { get; set; }
        public virtual DbSet<Booking> Bookings { get; set; }
    }
}
