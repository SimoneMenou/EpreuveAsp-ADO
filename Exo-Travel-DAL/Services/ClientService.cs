//Pour faire appel a ce dont j'ai besoin dans d'autres espace il est indispensable d'utiliser le using
using Exo_Travel_DAL.Entities;
//Notamment ici pour pouvoir traiter l'affichage et le reste il me faut la représentation des données. 
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using Exo_Travel_DAL;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_Travel_DAL.Services
{
    //Ici on va pouvoir recevoir les infos du client c'est un service rendu par cette classe
    //C'est ici qu'on met nos fonctionalités CRUD 
    //creer 
    //lire 
    //effacer
    class ClientService
    {
        //Pour pouvoir traiter ces données il faut une connexion 
        private string ConnectionString { get; set; } = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Eco-Travel-DB;Integrated Security=True";

        // je souhaite récupérer tout les clients 1ere methode 
        // Plusieurs methodes 
        public IEnumerable<Client> Get()
        {
            // Je crée ma connexion 
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                //J'appelle sqlcommand qui me permet de "parler sql"
                using(SqlCommand command = connection.CreateCommand())
                {
                    //Pour cette action ma commande sera celle ci :
                    command.CommandText = "SELECT * FROM [Client]";
                    connection.Open();
                    using(SqlDataReader reader = command.ExecuteReader())
                    {
                        //Le service s'occupe plutôt du comportement , des actions proposé mais le traitement se fera dans le mapper
                        while (reader.Read())
                        {
                            //Bien que le service ne traite pas les données il aura besoin de faire appel au mapper pour réaliser le service 
                            yield return reader.Toclient();
                        }
                    }
                }
                
            }
           // return null;

        }
        //Je souhaite ne récupérer que 1 client j'utilise l'identifiant qui pointera vers le client désiré
        public Client Get(int id )
        {
            return null;
        }
        //Je souhaite creer un nouveau Client il est "complet " c'est toute la fiche que l'on remplie alors j'ai besoin de l'entité 
        public int  Insert(Client entity)
        {
            return 0;
        }
        //Je souhaite mettre a jour le Client non seulement
        //je dois l'identifier pour mes modif mais aussi besoin de son entité mêmee si je n'en recrée pas une elle est une "meilleure" version d'elle même.
        public bool Update (int id , Client entity)
        {
            return false;
        }
        //Je souhaite effacer un client j'utilise l'identifiant qui pointera vers le client non désiré
        public bool Delete(int id)
        {
            return false;
        }

    }
}
