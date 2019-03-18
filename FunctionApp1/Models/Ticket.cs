using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace FunctionApp1.Models
{
    [Table("Ticket", Schema = "MCP")]
    public class Ticket
    {
        public Ticket()
        {
            this.Users = new HashSet<User>();
        }

        public Guid Id { get; set; }

        public string VehicleRegistrationMark { get; set; }

        public string Make { get; set; }

        public string Model { get; set; }

        public string Colour { get; set; }

        public string Location { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}