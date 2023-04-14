using Iglesia.Infraestructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iglesia.Core.Interface
{
    internal interface IDireccioneRepository
    {
        Task<IEnumerable<Direccione>> GetDirecciones();
        Task<Direccione> GetDireccion(int id);
        Task InsertDireccion(Direccione newdireccion);
        Task<bool> UpdateDireccion(Direccione direccion);
        Task<bool> DeleteDireccion(int id);
    }
}
