using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exo_Travel_MVC.Models
{
    public class ModelClient
    {
        public int IdClient { get; set; }
        //nvarchar(50)
        public string Nom { get; set; }
        //nvarchar(50)
        public string Prenom { get; set; }
        //nvarchar(255)
        public string AdresseMail { get; set; }
        //nvarchar(32)
        public string MotDePasse { get; set; }
        //nvarchar(50)
        public string Pays { get; set; }
        //nvarchar(20)
        public string Telephone { get; set; }
    }
}