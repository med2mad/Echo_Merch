namespace Echo_Merch.Models;

public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public string City { get; set; }
    public string Country { get; set; }

    public ICollection<Contact> Contacts { get; set; }
}
