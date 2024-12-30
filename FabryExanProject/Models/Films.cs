namespace FabryExanProject.Models
{
    public class Films
    {
        public int id { get; set; }
        public string title { get; set; } = string.Empty;
        public Genre genre { get; set; }
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
