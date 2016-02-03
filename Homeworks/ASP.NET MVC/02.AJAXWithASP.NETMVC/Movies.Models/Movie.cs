namespace Movies.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Movie
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Title")]
        [StringLength(200, MinimumLength = 1, ErrorMessage = "Movie title should be between 1 and 200 chars.")]
        public string Title { get; set; }

        [Display(Name = "Year")]
        [Range(1900, 2016, ErrorMessage = "Movie year should be after 1900 year.")]
        public int Year { get; set; }

        public int LeadingMaleRoleId { get; set; }

        public virtual Actor LeadingMaleRole { get; set; }

        public  int LeadingFemaleRoleId { get; set; }

        public virtual Actor LeadingFemaleRole { get; set; }

        [Display(Name = "Studio name")]
        public string StudioName { get; set; }

        [Display(Name = "Studio address")]
        public string StudioAddress { get; set; }
    }
}