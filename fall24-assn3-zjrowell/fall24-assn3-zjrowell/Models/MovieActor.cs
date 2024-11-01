using System;
namespace fall24_assn3_zjrowell.Models;

public class MovieActor
{
    public int MovieId { get; set; }
    public Movie Movie { get; set; }

    public int ActorId { get; set; }
    public Actor Actor { get; set; }
}

