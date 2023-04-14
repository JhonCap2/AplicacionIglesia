using System;
using System.Collections.Generic;

namespace Iglesia.Infraestructure.Data;

public partial class RedesSociale
{
    public Guid IdRedSocial { get; set; }

    public string? Nombre { get; set; }

    public virtual ICollection<Concilio> Concilios { get; set; } = new List<Concilio>();
}
