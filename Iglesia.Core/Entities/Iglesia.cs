using System;
using System.Collections.Generic;

namespace Iglesia.Infraestructure.Data;

public partial class Iglesia
{
    public Guid IdIglesia { get; set; }

    public Guid? IdConcilios { get; set; }

    public Guid? IdDireccion { get; set; }

    public string? Nombre { get; set; }

    public string? Web { get; set; }

    public virtual Concilio? IdConciliosNavigation { get; set; }

    public virtual Direccione? IdDireccionNavigation { get; set; }

    public virtual ICollection<Miembro> Miembros { get; set; } = new List<Miembro>();
}
