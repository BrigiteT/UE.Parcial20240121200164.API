using System;
using System.Collections.Generic;

namespace UE.Parcial20240121200164.API.Data;

public partial class Movie
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public string? Genre { get; set; }

    public string? ReleaseYear { get; set; }
}
