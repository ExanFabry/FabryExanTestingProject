using FabryExanProject.Models;

namespace FabryExanProject.Services
{
    public class Api
    {
        public readonly List<Films> AllFilms = new()
        {
            // Actie
            new Films { Id = 1, Title = "Mad Max: Fury Road", Genre = Genre.Action },
            new Films { Id = 2, Title = "Gladiator", Genre = Genre.Action },
            new Films { Id = 3, Title = "John Wick", Genre = Genre.Action },

            // Komedie
            new Films { Id = 4, Title = "Superbad", Genre = Genre.Comedy },
            new Films { Id = 5, Title = "The Hangover", Genre = Genre.Comedy },
            new Films { Id = 6, Title = "Step Brothers", Genre = Genre.Comedy },

            // Drama
            new Films { Id = 7, Title = "The Shawshank Redemption", Genre = Genre.Drama },
            new Films { Id = 8, Title = "Forrest Gump", Genre = Genre.Drama },
            new Films { Id = 9, Title = "Fight Club", Genre = Genre.Drama },

            // Fantasy
            new Films { Id = 10, Title = "The Lord of the Rings", Genre = Genre.Fantasy },
            new Films { Id = 11, Title = "Harry Potter and the Sorcerer's Stone", Genre = Genre.Fantasy },
            new Films { Id = 12, Title = "Pan's Labyrinth", Genre = Genre.Fantasy },

            // Horror
            new Films { Id = 13, Title = "The Exorcist", Genre = Genre.Horror },
            new Films { Id = 14, Title = "Get Out", Genre = Genre.Horror },
            new Films { Id = 15, Title = "A Nightmare on Elm Street", Genre = Genre.Horror },

            // Romantiek
            new Films { Id = 16, Title = "The Notebook", Genre = Genre.Romance },
            new Films { Id = 17, Title = "Pride and Prejudice", Genre = Genre.Romance },
            new Films { Id = 18, Title = "La La Land", Genre = Genre.Romance },

            // Sci-Fi
            new Films { Id = 19, Title = "Inception", Genre = Genre.SciFi },
            new Films { Id = 20, Title = "The Matrix", Genre = Genre.SciFi },
            new Films { Id = 21, Title = "Interstellar", Genre = Genre.SciFi },

            // Thriller
            new Films { Id = 22, Title = "Se7en", Genre = Genre.Thriller },
            new Films { Id = 23, Title = "Gone Girl", Genre = Genre.Thriller },
            new Films { Id = 24, Title = "Zodiac", Genre = Genre.Thriller }
        };
    }
}
