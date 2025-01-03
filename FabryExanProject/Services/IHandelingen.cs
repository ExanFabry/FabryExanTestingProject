using FabryExanProject.Models;

namespace FabryExanProject.Services
{
    public interface IHandelingen
    {
        public List<Films> AllFilms();
        public Task<Films> ReturnFilmWithGenre(string genre);
    }
}
