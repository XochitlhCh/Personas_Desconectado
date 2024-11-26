using System;
using System.Collections.Generic;

namespace Personas_Conectado.Models;

public partial class Persona
{
    public int IdPersona { get; set; }

    public string? Nombre { get; set; }

    public int? Edad { get; set; }

    public int? Genero { get; set; }
}
