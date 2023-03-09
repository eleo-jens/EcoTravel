using EcoTravel_Common.Repositories;
using EcoTravel_DAL.Entities;
using EcoTravel_DAL.Mapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoTravel_DAL.Services
{
    public class ProprietaireService : IProprietaireRepository<Proprietaire, int>
    {
        private string ConnectionString { get; set; } = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=EcoTravelDB;Integrated Security=True";

        public Proprietaire Get(int id)
        {
            using (SqlConnection cnx = new SqlConnection(ConnectionString))
            {
                using (SqlCommand command = cnx.CreateCommand())
                {
                    command.CommandText = @"
                        SELECT [idProprietaire], [nom], [prenom], [pays], [telephone], [email], [password] 
                        FROM [Proprietaire] JOIN [Client] 
                        ON [Client].[idClient] = [Proprietaire].[idProprietaire]
                        WHERE [idProprietaire] = @id";
                    command.Parameters.AddWithValue("id", id);
                    cnx.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return reader.ToProprietaire();
                        }
                        return null;
                    }
                }
            }
        }

        public int Insert(Proprietaire entity)
        {
            using (SqlConnection cnx = new SqlConnection(ConnectionString))
            {
                using (SqlCommand command = cnx.CreateCommand())
                {
                    command.CommandText = @"INSERT INTO [Proprietaire] ([idProprietaire]) VALUES (@idClient)";
  
                    //command.Parameters.AddWithValue("idClient", entity.idProprietaire);
                    // d' ou provient l'id du client ? Quand pn clique sur ajouter logement on prend l'id du Client connecté à la session?

                    cnx.Open();

                    return (int)command.ExecuteScalar();
                }
            }
        }
    }
}
