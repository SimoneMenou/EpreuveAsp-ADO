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
using Exo_Travel_common.Repository;

namespace Exo_Travel_DAL.BLLService
{
    //Ici on va pouvoir recevoir les infos du client c'est un service rendu par cette classe
    //C'est ici qu'on met nos fonctionalités CRUD 
    //creer 
    //lire 
    //effacer
   public class ClientService : IClientRepository<Client, int>

    {
        //Pour pouvoir traiter ces données il faut une connexion 
        private string ConnectionString { get; set; } = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=EcoTravel;Integrated Security=True";

        // je souhaite récupérer tout les clients 1ere methode 
        // Plusieurs methodes 
        public IEnumerable<Client> Get()
        {
            // Je crée ma connexion 
            using (SqlConnection connection = new SqlConnection(ConnectionString))

            {
                //J'appelle sqlcommand qui me permet de "parler sql"
                using (SqlCommand command = connection.CreateCommand())
                {
                    //Pour cette action ma commande sera celle ci :
                    command.CommandText = "SELECT * FROM [Client]";
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
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
        public Client Get(int id)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT [IdClient],[Nom],[Prenom],[AdresseMail],[MotDePasse],[Pays],[Telephone] WHERE [IdClient] = @id";
                    command.Parameters.AddWithValue("id", id);
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read()) return reader.Toclient();
                        return null;
                    }
                }

            }

        }
        //Je souhaite creer un nouveau Client il est "complet " c'est toute la fiche que l'on remplie alors j'ai besoin de l'entité 
        public int Insert(Client entity)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = @"INSERT INTO [Client]
                                          ([Nom],[Prenom],[AdresseMail],[MotDePasse],[Pays],[Telephone])
                                            OUTPUT INSERTED.IdClient
                                          VALUES (@Nom ,@Prenom ,@AdresseMail ,@MotDePasse ,@Pays ,@Telephone )";

                    command.Parameters.AddWithValue("Nom", entity.Nom);
                    command.Parameters.AddWithValue("Prenom", entity.Prenom);
                    command.Parameters.AddWithValue("AdresseMail", entity.AdresseMail);
                    command.Parameters.AddWithValue("MotDePasse", entity.MotDePasse);
                    command.Parameters.AddWithValue("Pays", entity.Pays);
                    command.Parameters.AddWithValue("Telephone", entity.Telephone);
                    connection.Open();
                    int Id = (int)command.ExecuteScalar();// casting
                    connection.Close();
                    return Id;
                    //Insererer un Client

                }

            }
        }
            //Je souhaite mettre a jour le Client non seulement
            //je dois l'identifier pour mes modif mais aussi besoin de son entité mêmee si je n'en recrée pas une elle est une meilleure version d'elle même.
            // Dans un premier temps je vais me concentrer sur Insert et Delete 
            /*public bool Update (int id , Client entity)
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                    return false;
            }
            */
            //Je souhaite effacer un client j'utilise l'identifiant qui pointera vers le client non désiré
            public bool Delete(int id)
            {
                bool success = false;
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    using (SqlCommand command = connection.CreateCommand())
                    {
                        command.CommandText = @"DELETE FROM [Client] WHERE [IdClient] = @Id";
                        command.Parameters.AddWithValue("Id", id);

                        connection.Open();
                        int ligneaffectee = command.ExecuteNonQuery();
                        if (ligneaffectee > 0)
                        {
                            success = true;
                        }
                        connection.Close();
                    }
                }
                return success;

            }
        }
    }

