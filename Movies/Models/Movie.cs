using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Movies.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        [StringLength(32, MinimumLength = 2)]
        [DisplayName("Название")]
        public string Title  { get; set; }

        [Display(Description ="Релиз")]
        [RangeAttribute(typeof(DateOnly), "1895-10-14", "2032-12-31")]
        public DateOnly ReleaseDate { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z()\s-]*$")]
        public string? Genre  { get; set; }
        public decimal? Price { get; set; }
    }
}
