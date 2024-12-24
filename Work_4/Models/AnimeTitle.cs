using System;
using System.Collections.Generic;

namespace Work_4.Models;

public partial class AnimeTitle
{
    public int Id { get; set; }

    public short IdAnimeType { get; set; }

    public short IdGenre { get; set; }

    public int IdUser { get; set; }

    public string OriginalName { get; set; } = null!;

    public string TitleName { get; set; } = null!;

    public short? YearOfRealise { get; set; }

    public string? Description { get; set; }

    public string? Poster { get; set; }

    public short? CountOfSeries { get; set; }

    public short? Duration { get; set; }

    public bool IsComplete { get; set; }

    public string? Studio { get; set; }

    public virtual AnimeType IdAnimeTypeNavigation { get; set; } = null!;

    public virtual Genre IdGenreNavigation { get; set; } = null!;

    public virtual User IdUserNavigation { get; set; } = null!;
}
