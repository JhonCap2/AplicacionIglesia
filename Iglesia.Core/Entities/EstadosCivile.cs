using System;
using System.Collections.Generic;

namespace Iglesia.Infraestructure.Data;

public partial class EstadosCivile
{
    public Guid IdEstadoCivil { get; set; }

    public string? Nombre { get; set; }

    public virtual ICollection<Miembro> Miembros { get; set; } = new List<Miembro>();
}
