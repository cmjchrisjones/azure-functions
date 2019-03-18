using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace FunctionApp1.Models
{
    public class Context : DbContext
    {
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Ticket> Tickets { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasMany<Ticket>(a => a.TicketsIssued).WithMany(u => u.Users).Map(ua =>
            {
                ua.MapLeftKey("UserId");
                ua.MapRightKey("TicketId");
                ua.ToTable("TicketMapping", "MCP");
            });
        }
    }
}