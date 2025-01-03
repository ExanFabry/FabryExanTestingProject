using FabryExanProject.Models;

namespace FabryExanProject.Services
{
    public class Handelingen : IHandelingen
    {
        public Handelingen()
        {
            
        }
        public List<Films> AllFilms()
        {
            Api allFilms = new Api();
            return allFilms.AllFilms;
        }
        public Task<Films> ReturnFilmWithGenre(string genre)
        {
            List<Films> allFilms = AllFilms();
            List<Films> remainingFilms = new List<Films>();
            foreach (Films item in allFilms)
            {
                if (item.Genre == (Genre)Enum.Parse(typeof(Genre), genre))
                {
                    remainingFilms.Add(item);
                }
            }
            Random random = new Random();
            int randomNumber = random.Next(0, (remainingFilms.Count() - 1));
            return Task.FromResult(remainingFilms[randomNumber]);
        }
    }
}
