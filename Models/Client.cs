using System.ComponentModel.DataAnnotations.Schema;

namespace Echo_Merch.Models
{
    public class Client
    {
        //public int clientid { get; set; } // Primary Key

        public int age { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string? Name { get; set; }

        public string? Description { get; set; }
    }
}
