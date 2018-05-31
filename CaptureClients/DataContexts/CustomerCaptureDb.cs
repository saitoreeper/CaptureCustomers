using CaptureClients.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CaptureClients.DataContexts
{
    public class CustomerCaptureDb : DbContext
    {
        public CustomerCaptureDb()
            : base("DefaultConnection")
        {
        }

        // Momentum.Entities.Base
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Contact> Contacts { get; set; }    
    }
}