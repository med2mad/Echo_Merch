using System.ComponentModel.DataAnnotations.Schema;

namespace Echo_Merch.Models;

public class ClientDTO
{
    public int age { get; set; }

    public string Name { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;
}
