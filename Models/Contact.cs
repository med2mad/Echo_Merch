namespace Echo_Merch.Models;

public class Contact
{
    public int Id { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public string WhatsApp { get; set; } = string.Empty;
    public string address { get; set; } = string.Empty;

    public int? UserId { get; set; }
    public User? User { get; set; }
}


public class ContactDTO
{
    public string Email { get; set; }
    public string Phone { get; set; }
}
