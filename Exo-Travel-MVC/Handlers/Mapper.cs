using Exo_Travel_BLL.Entities;
using Exo_Travel_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exo_Travel_MVC.Handlers
{
    public static class Mapper
    {
        public static ModelClient ToModelClient(this Client entity)
        {
            if (entity is null) return null;
            return new ModelClient()
            {

                IdClient = entity.IdClient,
                Nom = entity.Nom,
                Prenom = entity.Prenom,
                AdresseMail = entity.AdresseMail,
                MotDePasse = entity.MotDePasse,
                Pays = entity.Pays,
                Telephone = entity.Telephone
            };

        }
    }
}
