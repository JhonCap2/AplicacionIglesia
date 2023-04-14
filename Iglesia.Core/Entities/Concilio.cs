using System;
using System.Collections.Generic;

namespace Iglesia.Infraestructure.Data;

public partial class Concilio
{
    public Guid IdConcilio { get; set; }

    public Guid? IdRedSocial { get; set; }

    public string? Rnc { get; set; }

    public string? Correo { get; set; }

    public string? Web { get; set; }

    public virtual RedesSociale? IdRedSocialNavigation { get; set; }

    public virtual ICollection<Iglesia> Iglesia { get; set; } = new List<Iglesia>();
}
