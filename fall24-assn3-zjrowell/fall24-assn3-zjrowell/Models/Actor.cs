using System;
namespace fall24_assn3_zjrowell.Models;

public class Actor
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Gender { get; set; }
    public int Age { get; set; }
    public string IMDBLink { get; set; }
    public string Photo { get; set; }
    public List<MovieActor> MovieActors { get; set; } = new List<MovieActor>();
}

