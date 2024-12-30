using FabryExanProject.Models;

namespace FabryExanProject.Services
{
    public class BeslissingModule
    {
        private static readonly List<Films> AllFilms = new()
        {
            // Actie
            new Films { id = 1, title = "Mad Max: Fury Road", genre = Genre.Action },
            new Films { id = 2, title = "Gladiator", genre = Genre.Action },
            new Films { id = 3, title = "John Wick", genre = Genre.Action },

            // Komedie
            new Films { id = 4, title = "Superbad", genre = Genre.Comedy },
            new Films { id = 5, title = "The Hangover", genre = Genre.Comedy },
            new Films { id = 6, title = "Step Brothers", genre = Genre.Comedy },

            // Drama
            new Films { id = 7, title = "The Shawshank Redemption", genre = Genre.Drama },
            new Films { id = 8, title = "Forrest Gump", genre = Genre.Drama },
            new Films { id = 9, title = "Fight Club", genre = Genre.Drama },

            // Fantasy
            new Films { id = 10, title = "The Lord of the Rings", genre = Genre.Fantasy },
            new Films { id = 11, title = "Harry Potter and the Sorcerer's Stone", genre = Genre.Fantasy },
            new Films { id = 12, title = "Pan's Labyrinth", genre = Genre.Fantasy },

            // Horror
            new Films { id = 13, title = "The Exorcist", genre = Genre.Horror },
            new Films { id = 14, title = "Get Out", genre = Genre.Horror },
            new Films { id = 15, title = "A Nightmare on Elm Street", genre = Genre.Horror },

            // Romantiek
            new Films { id = 16, title = "The Notebook", genre = Genre.Romance },
            new Films { id = 17, title = "Pride and Prejudice", genre = Genre.Romance },
            new Films { id = 18, title = "La La Land", genre = Genre.Romance },

            // Sci-Fi
            new Films { id = 19, title = "Inception", genre = Genre.SciFi },
            new Films { id = 20, title = "The Matrix", genre = Genre.SciFi },
            new Films { id = 21, title = "Interstellar", genre = Genre.SciFi },

            // Thriller
            new Films { id = 22, title = "Se7en", genre = Genre.Thriller },
            new Films { id = 23, title = "Gone Girl", genre = Genre.Thriller },
            new Films { id = 24, title = "Zodiac", genre = Genre.Thriller }
        };

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
