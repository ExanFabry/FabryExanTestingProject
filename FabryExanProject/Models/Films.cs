namespace FabryExanProject.Models
{
    public class Films
    {
        public Films()
        {

        }
        public Films(int id, string title, Genre genre)
        {
            Id = id;
            Title = title;
            Genre = genre;
        }
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public Genre Genre { get; set; }
    }
    public enum Genre
    {
        Action,
        Comedy,
        Drama,
        Fantasy,
        Horror,
        Romance,
        SciFi,
        Thriller
    }
}
