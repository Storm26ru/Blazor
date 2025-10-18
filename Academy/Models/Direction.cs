using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Academy.Models
{
    public class Direction
    {
        [Key]
        [Column(TypeName = "tinyint")]
        public short direction_id { get; set; }
        [Required]
        public string direction_name { get; set; }
    }
}
