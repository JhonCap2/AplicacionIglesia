using Iglesia.Infraestructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iglesia.Core.Interface
{
    internal interface IEstadoCivilRepository
    {

        Task<IEnumerable<EstadosCivile>> GetEstadoCiviles();
        Task<EstadosCivile> GetEstadosCivil(int id);
        Task InsertEstadosCivil(EstadosCivile newestadosCivile);
        Task<bool> UpdateEstadosCivil(EstadosCivile estadosCivil);
        Task<bool> DeleteEstadosCivil(int id);
    }
}
