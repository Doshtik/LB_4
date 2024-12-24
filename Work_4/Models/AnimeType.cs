using System;
using System.Collections.Generic;

namespace Work_4.Models;

public partial class AnimeType
{
    // Свойства класса соответствующее полям таблицы в PostgreSQL
    public short Id { get; set; }

    public string AnimeOfType { get; set; } = null!;

    public virtual ICollection<AnimeTitle> AnimeTitles { get; set; } = new List<AnimeTitle>();
}
