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
        public byte direction {  get; set; }
        [Required]
        public byte form {  get; set; }
    }
}
