using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Echo_Merch.Models;

public class ContactDTO
{
    public int Id { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
}
