using System;
using System.Collections.Generic;

namespace FutbolApi.Models;

public partial class Club
{
    public int ClubId { get; set; }

    public string Nombre { get; set; } = null!;

    public string AnioFundacion { get; set; } = null!;

    public string Presidente { get; set; } = null!;

    public string Entrenador { get; set; } = null!;

    public string Estadio { get; set; } = null!;

    public int LigaId { get; set; }

    public int PaisId { get; set; }

    public virtual ICollection<Jugador> Jugadors { get; set; } = new List<Jugador>();

    public virtual Liga Liga { get; set; } = null!;

    public virtual Pais Pais { get; set; } = null!;
}
