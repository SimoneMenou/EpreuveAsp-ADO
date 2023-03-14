using Exo_Travel_BLL.Entities;
using DALEntities = Exo_Travel_DAL.Entities;
using Exo_Travel_common.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_Travel_BLL.Services
{
    //Ce service propre au bll communique avec le service 
   public class ClientService: IClientRepository<Client , int >
    {
        //Recuperer les infos de la dal avec un nouveau crud propre au bll 
        //bll est dépendant de la dal pour a son tour traiter les données
        // je vais creer le chemin de la dépendance (class de la dal doit être public pour l'accés)
        //public Exo_Travel_DAL.BLLService.ClientService _repository;

        //public ClientService()
        //{
        //    _repository = new Exo_Travel_DAL.BLLService.ClientService();
        //    // pour creer le lien instancier la dal 
        //}

        private readonly IClientRepository<DALEntities.Client, int> _repository;
        public ClientService (IClientRepository<DALEntities.Client, int> repository)
        {
            _repository = repository;

        }
        public IEnumerable<Client> Get()
        {
           return  _repository.Get().Select(e=> e.ToBLL());

        }
        public Client Get(int id)
        {
            return _repository.Get(id).ToBLL();
        }
        public int Insert(Client entity )
        {
            return _repository.Insert(entity.ToDAL()) ;
        }

        // je vais skipper l'update

        public bool Delete(int id)
        {
            return _repository.Delete(id);
        }


    }
}
