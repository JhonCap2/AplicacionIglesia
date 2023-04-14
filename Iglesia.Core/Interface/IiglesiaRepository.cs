using Iglesia.Infraestructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iglesia.Core.Interface
{
    internal interface IIglesiaRepository
    {
        Task<IEnumerable<Iglesia>> GetIglesias();
        Task<Iglesia> GetIglesia(int id);
        Task InsertIglesia(Iglesia newiglesia);
        Task<bool> UpdateIglesia(Iglesia iglesia);
        Task<bool> DeleteIglesia(int id);
    }
}
