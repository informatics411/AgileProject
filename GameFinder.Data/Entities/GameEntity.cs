using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

public class GameEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [ForeignKey("GameSystemEntity")]
        public int GameSystemID { get; set; }
        public virtual GameSystemEntity GameSystem { get; set; }
        [ForeignKey("GenreEntity")]
        public int GenreID { get; set; }
    }