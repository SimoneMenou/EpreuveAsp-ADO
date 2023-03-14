using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_Travel_common.Repository
{
    //Dans ce dossier on retrouve des constructions générique qui me permetront d'être utiliser en fonction des besoins.
    public interface IGetRepository<TEntity,TId>
    {
        IEnumerable<TEntity> Get();
        TEntity Get(TId id);
    }
}
