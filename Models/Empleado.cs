using System;
using System.Collections.Generic;

namespace PrimerAPI.Models;

public partial class Empleado
{
    public int IdEmpleados { get; set; }

    public int IdPuesto { get; set; }

    public string? Nombre { get; set; }

    public string? Apellido { get; set; }

    public virtual Puesto? IdPuestoNavigation { get; set; }
}
