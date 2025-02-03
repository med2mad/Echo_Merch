using System.ComponentModel.DataAnnotations.Schema;

namespace Echo_Merch.Models;

public class Table1
{
    public int Id { get; set; }
    public string parent_value { get; set; }


    public Table2 Child_Row { get; set; }

}
