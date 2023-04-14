using System;
using System.Collections.Generic;

namespace Iglesia.Infraestructure.Data;

public partial class Direccione
{
    public Guid IdDireccion { get; set; }

    public string? DireccionIglesia { get; set; }

    public virtual ICollection<Iglesia> Iglesia { get; set; } = new List<Iglesia>();

    public virtual ICollection<Miembro> Miembros { get; set; } = new List<Miembro>();
}
