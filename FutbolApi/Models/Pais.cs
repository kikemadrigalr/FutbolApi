using System;
using System.Collections.Generic;

namespace FutbolApi.Models;

public partial class Pais
{
    public int PaisId { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<Club> Clubs { get; set; } = new List<Club>();

    public virtual ICollection<Liga> Ligas { get; set; } = new List<Liga>();
}
