using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_Travel_DAL.Entities
{
    //Dans ma dal mes tables devienne des classes et mes champs des propriétés
   public class Client
    {
        public int IdClient { get; set;}
        public string Nom { get; set;}
        public string Prenom { get; set;}
        public string AdresseMail { get; set;}
        public string MotDePasse { get; set;}
        public string Pays { get; set;}
        public string Telephone { get; set;}
}
}
