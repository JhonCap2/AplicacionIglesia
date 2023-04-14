using Iglesia.Infraestructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iglesia.Core.Interface
{
    public interface  IConciliosRepository
    {
        Task<IEnumerable<Concilio>> GetConcilios();
        Task<Concilio> GetConcilio(int id);
        Task InsertConcilio(Concilio newconcilios);
        Task<bool> UpdateConcilio(Concilio concilio);
        Task<bool> DeleteConcilio(int id);
    }
}
