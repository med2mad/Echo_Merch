namespace Echo_Merch.Models;

public class Table1_
{
    public int Id { get; set; }
    public string Value { get; set; }

    public ICollection<Table1> Table1 { get; set; }
}
