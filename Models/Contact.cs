using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Echo_Merch.Models;

public class Contact
{
    public int Id { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public string Mobile { get; set; }
    public string WhatsApp { get; set; }

    public User? User { get; set; }
}
