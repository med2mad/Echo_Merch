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


public class ContactDTO
{
    public string Email { get; set; }
    public string Phone { get; set; }
}
