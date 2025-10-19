using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Academy.Models
{
    public class Group
    {
        [Key]
        public int group_id { get; set; }
        [Required]
        public string group_name { get; set; }
        [Required]
        [Column(TypeName ="tinyint")]
        public int direction {  get; set; }
        [Required]
        [Column(TypeName ="tinyint")]
        public int form {  get; set; }
    }
}
