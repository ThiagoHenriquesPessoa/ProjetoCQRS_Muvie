using Movies.Core.Entities;
using Movies.Core.Repositories.Base;

namespace Movies.Core.Repositories
{
    public interface IMoveRepository : IRepository<Movie>
    {
        Task<IEnumerable<Movie>> GetMuviesByDirectorName(string directorName);
    }
}