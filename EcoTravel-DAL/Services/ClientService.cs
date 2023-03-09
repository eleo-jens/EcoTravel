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
    public class ClientService : IClientRepository<Client, int>
    {
        private string ConnectionString { get; set; } = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=EcoTravelDB;Integrated Security=True";
        public Client Get(int id)
        {
            using (SqlConnection cnx = new SqlConnection(ConnectionString))
            {
                using (SqlCommand command  = cnx.CreateCommand())
                {
                    command.CommandText = "SELECT [idClient], [nom], [prenom], [pays], [telephone], [email], [password] FROM [Client] WHERE [idClient] = @id";
                    command.Parameters.AddWithValue("id", id);
                    cnx.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return reader.ToClient();
                        }
                        return null;
                    }
                }
            }
        }

        public int Insert(Client entity)
        {
            using (SqlConnection cnx = new SqlConnection(ConnectionString))
            {
                using (SqlCommand command = cnx.CreateCommand())
                {
                    command.CommandText = "SP_Client_Add";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("email", entity.email);
                    command.Parameters.AddWithValue("password", entity.password);
                    command.Parameters.AddWithValue("nom", entity.nom);
                    command.Parameters.AddWithValue("prenom", entity.prenom);
                    command.Parameters.AddWithValue("pays", entity.pays);
                    command.Parameters.AddWithValue("telephone", entity.telephone);

                    cnx.Open();

                    return (int)command.ExecuteScalar();
                }
            }
        }
    }
}
