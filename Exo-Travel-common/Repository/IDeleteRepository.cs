using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_Travel_common.Repository
{
   public interface IDeleteRepository<TId>
    {
         bool Delete(TId id);
    }
}
