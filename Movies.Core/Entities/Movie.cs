using Movies.Core.Entities.Base;

namespace Movies.Core.Entities
{
    public class Movie : Entity
    {
        public string MoveName { get; set; }
        public string DirectorName { get; set; }
        public string ReleaseYear { get; set; }
    }
}
