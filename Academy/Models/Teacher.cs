using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata;

namespace Academy.Models
{
    public class Teacher
    {
        [Key]
        public short teacher_id { get; set; }
        [Required]
        public string last_name { get; set; }
        [Required]
        public string first_name { get; set; }
        public string? middle_name { get; set; }
        [Required]
        public DateOnly birth_date { get; set; }
        [EmailAddress]
        public string? email { get; set; }
        [Phone]
        public string? phone { get; set; }
        public byte[]? photo { get; set; }
        [Required]
        public DateOnly work_since { get; set; }
        [Required]
        public decimal rate { get; set; }
    }
}
