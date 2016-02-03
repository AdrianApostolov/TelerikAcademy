namespace Movies.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Actor
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Actor Name")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Actor name should be between 2 and 50 chars.")]
        public string Name { get; set; }

        [Display(Name = "Actor Age")]
        [Range(1, 120, ErrorMessage = "Actor age should be between 1 and 120 years")]
        public int Age { get; set; }
    }
}