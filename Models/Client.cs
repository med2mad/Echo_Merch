using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Echo_Merch.Models
{
	public class Client
	{
		public int clientid { get; set; } // Primary Key

		[Column(TypeName = "varchar(50)")]
		public string Name { get; set; } = string.Empty;

		public string Description { get; set; }= string.Empty;
	}
}
