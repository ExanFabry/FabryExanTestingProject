using FabryExanProject.Models;

namespace FabryExanProject.Services
{
    public class BeslissingModule
    {
        public static bool ChooseGenre(string genre)
        {
            if (!Enum.TryParse(typeof(Genre), genre, true, out _))
            {
                throw new ArgumentException($"Ongeldige optie meegegeven: '{genre}'");
            }
            return true;
        }
    }
}
