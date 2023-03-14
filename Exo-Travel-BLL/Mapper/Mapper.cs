using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL = Exo_Travel_BLL.Entities;
using DAL = Exo_Travel_DAL.Entities;


namespace Exo_Travel_BLL
{
    static class Mapper
    {
        public static BLL.Client ToBLL( this DAL.Client entity)
        {
            if (entity is null) return null;
            return new BLL.Client()
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

        public static DAL.Client ToDAL(this BLL.Client entity)
        {
            if (entity is null) return null;
            return new DAL.Client()
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
}    }

