using System.ComponentModel.DataAnnotations.Schema;

namespace Echo_Merch.Models;

public class Table2
{
    public int Id { get; set; }
    public string child_value { get; set; }

    [ForeignKey("Table1")]
    public ICollection<Table1> Parents_Collection { get; set; }
}
