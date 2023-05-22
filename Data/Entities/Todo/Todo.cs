using System.ComponentModel.DataAnnotations;

namespace Data.Entities;

public class Todo
{
    [Key]
    public int id { get; set; }
    public string title { get; set; }

    public int date { get; set; }
    

    //
    //
    public List<TodoDescription> TodoDescriptions { get; set; }
}