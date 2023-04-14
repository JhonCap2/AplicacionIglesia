using System;
using System.Collections.Generic;

namespace Iglesia.Infraestructure.Data;

public partial class Miembro
{
    public Guid IdMiembro { get; set; }

    public Guid? IdDireccion { get; set; }

    public Guid? IdIglesia { get; set; }

    public Guid? IdEstadoCivil { get; set; }

    public Guid? IdProfecion { get; set; }

    public string? PrimerNombre { get; set; }

    public string? SegundoNombre { get; set; }

    public string? PrimerApellido { get; set; }

    public string? SegundoApellido { get; set; }

    public string? Apodo { get; set; }

    public DateTime? FechaDeNacimiento { get; set; }

    public virtual Direccione? IdDireccionNavigation { get; set; }

    public virtual EstadosCivile? IdEstadoCivilNavigation { get; set; }

    public virtual Iglesia? IdIglesiaNavigation { get; set; }

    public virtual Profecione? IdProfecionNavigation { get; set; }
}
