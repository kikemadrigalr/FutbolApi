﻿using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace FutbolApi.Models;

public partial class Jugador
{
    public int JugadorId { get; set; }

    public string Nombre { get; set; } = null!;

    public int Edad { get; set; }

    public int ClubId { get; set; }

    public string Posicion { get; set; } = null!;

    public int Numero { get; set; }

    //[JsonIgnore]
    //public virtual Club Club { get; set; } = null!;
    //public int Club { get; set; }
}
