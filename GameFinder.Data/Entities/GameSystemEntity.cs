using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class GameSystemEntity
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }
}