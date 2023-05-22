using System.ComponentModel.DataAnnotations;

namespace Data.Entities;

public class TodoDescription
{
    [Key]
    public int id { get; set; }
    //
    //
    //
    //
    //
    //
    public int TodoId { get; set; }
    public Todo Todo { get; set; }
}