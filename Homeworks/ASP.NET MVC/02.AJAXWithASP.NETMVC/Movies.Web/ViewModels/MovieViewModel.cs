namespace Movies.Web.ViewModels
{
    using Movies.Models;
    using Movies.Web.Infrastructure;

    using AutoMapper;

    public class MovieViewModel  : IMapFrom<Movie>, IHaveCustomMappings
    {
        public int Id { get; set; }

        public string Title { get; set; }
       
        public int Year { get; set; }

        public string LeadingMaleRole { get; set; }

        public  int LeadingMaleRoleAge { get; set; }

        public string LeadingFemaleRole { get; set; }

        public int LeadingFemaleRoleAge { get; set; }


        public string StudioName { get; set; }
    
        public string StudioAddress { get; set; }

        public void CreateMappings(IConfiguration configuration)
        {
            configuration.CreateMap<Movie, MovieViewModel>()
                .ForMember(m => m.LeadingMaleRole, opt => opt.MapFrom(u => u.LeadingMaleRole.Name));
            configuration.CreateMap<Movie, MovieViewModel>()
               .ForMember(m => m.LeadingMaleRoleAge, opt => opt.MapFrom(u => u.LeadingMaleRole.Age));
            configuration.CreateMap<Movie, MovieViewModel>()
                .ForMember(m => m.LeadingFemaleRole, opt => opt.MapFrom(u => u.LeadingFemaleRole.Name));
            configuration.CreateMap<Movie, MovieViewModel>()
               .ForMember(m => m.LeadingFemaleRoleAge, opt => opt.MapFrom(u => u.LeadingFemaleRole.Age));
        }
    }
}