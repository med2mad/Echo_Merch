namespace Echo_Merch.Models.DTOs;

public class UserDTO
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Username { get; set; }

    public ICollection<ContactDTO> Contacts { get; set; }
}
