using System;
using System.Collections.Generic;

namespace FutbolApi.Models;

public partial class Liga
{
    public int LigaId { get; set; }

    public string Nombre { get; set; } = null!;

    public string Temporada { get; set; } = null!;

    public int Equipos { get; set; }

    public int PaisId { get; set; }

    public virtual ICollection<Club> Clubs { get; set; } = new List<Club>();

    public virtual Pais Pais { get; set; } = null!;
}
