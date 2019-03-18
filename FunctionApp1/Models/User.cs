using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FunctionApp1.Models
{
    [Table("User", Schema = "MCP")]
    public class User
    {
        public User()
        {
            this.TicketsIssued = new HashSet<Ticket>();
        }

        [Required]
        public Guid Id { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required]
        public string AttendantId { get; set; }

        public virtual ICollection<Ticket> TicketsIssued { get; set; }
    }
}