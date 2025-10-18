using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
namespace Academy.Models
{
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int stud_id { get; set; }
        [Required]
        [Display(Name ="Фамилия")]
        public string last_name { get; set; }
        [Required]
        public string first_name { get; set; }
        public string middle_name { get; set; }
        [Required]
        public DateOnly birth_date { get; set; }
        [EmailAddress]
        public string? email { get; set; }
        [Phone]
        public string? phone { get; set; }
        public byte[]? photo { get; set; }
        public int group { get; set; }

    }
}
