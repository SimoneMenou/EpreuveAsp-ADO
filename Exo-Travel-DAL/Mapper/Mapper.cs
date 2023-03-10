using Exo_Travel_DAL;
using System.Data;
using Exo_Travel_DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_Travel_DAL
{
    static class Mapper
    {
        // la proprié de mon mapper un genre de cuisine interne pour le traitement de mes données.
        // je veux traiter mes données une par une 
        // Rem l'extension this qui donne l'accés direct a IdataRecord n'est possible que dans les classes static
        public static Client Toclient(this IDataRecord record)
        {
            //Gerer la non gestion de donné si il n'y a rien a "record"
            if (record is null)
            {
                return null;
            }

            return new Client()
            {
                //  Afin de les rendre utilisables dans le contexte de l'application le mapper à l'aide de recorde permettra de traiter les propriérté et Client.
                IdClient = (int)record[nameof(Client.IdClient)],
                Nom = (string)record[nameof(Client.Nom)],
                Prenom = (string)record[nameof(Client.Prenom)],
                AdresseMail = (string)record[nameof(Client.AdresseMail)],
                MotDePasse = "******",
                Pays = (string)record[nameof(Client.Pays)],
                Telephone = (string)record[nameof(Client.Telephone)]
            };
      

        }
    }
}
