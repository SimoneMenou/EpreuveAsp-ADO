using Exo_Travel_common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_Travel_common.Repository
{
    public interface IClientRepository<TEntity, TId>: IGetRepository<TEntity, TId>, IInsertRepository<TEntity, TId>, IDeleteRepository<TId> where TEntity : IClient
    {

    }
}
