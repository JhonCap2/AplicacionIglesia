using System;
using System.Collections.Generic;

namespace Iglesia.Infraestructure.Data;

public partial class Profecione
{
    public int IdProfecion { get; set; }

    public Guid IdProfecion1 { get; set; }

    public string? Nombre { get; set; }

    public virtual ICollection<Miembro> Miembros { get; set; } = new List<Miembro>();
}
