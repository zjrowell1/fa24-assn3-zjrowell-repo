using System;
namespace fall24_assn3_zjrowell.Models;

public class Movie
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string IMDBLink { get; set; }
    public string Genre { get; set; }
    public int YearOfRelease { get; set; }
    public string Poster { get; set; }
    public List<MovieActor> MovieActors { get; set; } = new List<MovieActor>();
}

