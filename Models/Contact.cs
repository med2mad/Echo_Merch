using System.ComponentModel.DataAnnotations.Schema;

namespace Echo_Merch.Models;

public class Contact
{
    public int Id { get; set; }
    [System.Text.Json.Serialization.JsonIgnore]
    public string Email { get; set; }
    public string Phone { get; set; }

    [System.Text.Json.Serialization.JsonIgnore]
    public User? User { get; set; }
}
