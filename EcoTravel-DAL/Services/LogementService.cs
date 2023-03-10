using System;
using EcoTravel_Common.Repositories;
using EcoTravel_DAL.Entities;
using EcoTravel_DAL.Mapper;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace EcoTravel_DAL.Services
{
    public class LogementService : ILogementRepository<Logement, int>
    {
        private string ConnectionString { get; set; } = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=EcoTravelDB;Integrated Security=True";
        
        public bool Delete(int id)
        {
            using (SqlConnection cnx = new SqlConnection(ConnectionString))
            {
                using (SqlCommand command = cnx.CreateCommand())
                {
                    command.CommandText = "DELETE FROM [Logement] WHERE [idLogement] = @id";
                    command.Parameters.AddWithValue("id", id);
                    cnx.Open();
                    return command.ExecuteNonQuery() > 0;
                }
            }
        }

        public IEnumerable<Logement> Get()
        {
            using (SqlConnection cnx = new SqlConnection(ConnectionString))
            {
                using (SqlCommand command = cnx.CreateCommand())
                {
                    command.CommandText = "SELECT * FROM [Logement]";
                    cnx.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            yield return reader.ToLogement();
                        }
                    }
                }
            }
        }

        public Logement Get(int id)
        {
            using (SqlConnection cnx = new SqlConnection(ConnectionString))
            {
                using (SqlCommand command = cnx.CreateCommand())
                {
                    command.CommandText = "SELECT * FROM [Logement] WHERE [idLogement] = @id";
                    command.Parameters.AddWithValue("id", id);
                    cnx.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return reader.ToLogement();
                        }
                        return null;
                    }
                }
            }
        }

        public int Insert(Logement entity)
        {
            using (SqlConnection cnx = new SqlConnection(ConnectionString))
            {
                using (SqlCommand command = cnx.CreateCommand())
                {
                    command.CommandText = @"INSERT INTO [Logement] ([nom], [descriptionCourte], 
                    [descriptionLongue], [nbChambres], [nbPieces], [nbSDB], [nbWC], [balcon], [airco],
                    [wifi], [minibar], [animauxAdmis], [piscine], [parking], [voiturier],
                    [roomService], [spa], [prixNuitPersonne], [capacite], [longitude],
                    [latitude], [rue], [numero], [codePostal], [pays], [idCategorie], [idProprietaire]) 
                    OUTPUT [Inserted].[idLogement]
                    VALUES (@nom, @descriptionCourte, 
                    @descriptionLongue, @nbChambres, @nbPieces, @nbSDB, @nbWC, @balcon, @airco,
                    @wifi, @minibar, @animauxAdmis, @piscine, @parking, @voiturier,
                    @roomService, @spa, @prixNuitPersonne, @capacite, @longitude,
                    @latitude, @rue, @numero, @codePostal, @pays, @idCategorie, @idProprietaire)";

                    command.Parameters.AddWithValue("nom", entity.nom);
                    command.Parameters.AddWithValue("descriptionCourte", entity.descriptionCourte);
                    command.Parameters.AddWithValue("descriptionLongue", entity.descriptionLongue);
                    command.Parameters.AddWithValue("nbChambres", entity.nbChambres);
                    command.Parameters.AddWithValue("nbPieces", entity.nbPieces);
                    command.Parameters.AddWithValue("nbSDB", entity.nbSDB);
                    command.Parameters.AddWithValue("nbWC", entity.nbWC);
                    command.Parameters.AddWithValue("balcon", entity.balcon);
                    command.Parameters.AddWithValue("airco", entity.airco);
                    command.Parameters.AddWithValue("wifi", entity.wifi);
                    command.Parameters.AddWithValue("minibar", entity.minibar);
                    command.Parameters.AddWithValue("animauxAdmis", entity.animauxAdmis);
                    command.Parameters.AddWithValue("piscine", entity.piscine);
                    command.Parameters.AddWithValue("parking", entity.parking);
                    command.Parameters.AddWithValue("voiturier", entity.voiturier);
                    command.Parameters.AddWithValue("roomService", entity.roomService);
                    command.Parameters.AddWithValue("spa", entity.spa);
                    command.Parameters.AddWithValue("prixNuitPersonne", entity.prixNuitPersonne);
                    command.Parameters.AddWithValue("capacite", entity.capacite);
                    command.Parameters.AddWithValue("longitude", entity.longitude);
                    command.Parameters.AddWithValue("latitude", entity.latitude);
                    command.Parameters.AddWithValue("rue", entity.rue);
                    command.Parameters.AddWithValue("numero", entity.numero);
                    command.Parameters.AddWithValue("codePostal", entity.codePostal);
                    command.Parameters.AddWithValue("pays", entity.pays);
                    command.Parameters.AddWithValue("idCategorie", entity.idCategorie);
                    command.Parameters.AddWithValue("idProprietaire", entity.idProprietaire);

                    cnx.Open();

                    return (int)command.ExecuteScalar();
                }
            }
        }

        public bool Update(Logement entity, int id)
        {
            using (SqlConnection cnx = new SqlConnection(ConnectionString))
            {
                using (SqlCommand command = cnx.CreateCommand())
                {
                    command.CommandText = @"UPDATE [Logement] 
                    SET [nom] = @nom, [descriptionCourte] = @descriptionCourte, 
                    [descriptionLongue] = @descriptionLongue, [nbChambres] = @nbChambres, 
                    [nbPieces] = @nbPieces, [nbSDB] = @nbSDB, [nbWC] = @nbWC, [balcon] = @balcon,
                    [airco] = @airco, [wifi] = @wifi, [minibar] = @minibar, [animauxAdmis] = @animauxAdmis, 
                    [piscine] = @piscine, [parking] = @parking, [voiturier] = @voiturier,
                    [roomService] = @roomService, [spa] = @spa, [prixNuitPersonne] = @prixNuitPersonne,
                    [capacite] = @capacite, [longitude] = @longitude,
                    [latitude] = @latitude, [rue] = @rue, [numero] = @numero, 
                    [codePostal] = @codePostal, [pays] = @pays, [dateAjout] = @dateAjout) 
                    WHERE [idLogement] = @id";

                    command.Parameters.AddWithValue("id", id);
                    command.Parameters.AddWithValue("nom", entity.nom);
                    command.Parameters.AddWithValue("descriptionCourte", entity.descriptionCourte);
                    command.Parameters.AddWithValue("descriptionLongue", entity.descriptionLongue);
                    command.Parameters.AddWithValue("nbChambres", entity.nbChambres);
                    command.Parameters.AddWithValue("nbPieces", entity.nbPieces);
                    command.Parameters.AddWithValue("nbSDB", entity.nbSDB);
                    command.Parameters.AddWithValue("nbWC", entity.nbWC);
                    command.Parameters.AddWithValue("balcon", entity.balcon);
                    command.Parameters.AddWithValue("airco", entity.airco);
                    command.Parameters.AddWithValue("wifi", entity.wifi);
                    command.Parameters.AddWithValue("minibar", entity.minibar);
                    command.Parameters.AddWithValue("animauxAdmis", entity.animauxAdmis);
                    command.Parameters.AddWithValue("piscine", entity.piscine);
                    command.Parameters.AddWithValue("parking", entity.parking);
                    command.Parameters.AddWithValue("voiturier", entity.voiturier);
                    command.Parameters.AddWithValue("roomService", entity.roomService);
                    command.Parameters.AddWithValue("spa", entity.spa);
                    command.Parameters.AddWithValue("prixNuitPersonne", entity.prixNuitPersonne);
                    command.Parameters.AddWithValue("capacite", entity.capacite);
                    command.Parameters.AddWithValue("longitude", entity.longitude);
                    command.Parameters.AddWithValue("latitude", entity.latitude);
                    command.Parameters.AddWithValue("rue", entity.rue);
                    command.Parameters.AddWithValue("numero", entity.numero);
                    command.Parameters.AddWithValue("codePostal", entity.codePostal);
                    command.Parameters.AddWithValue("pays", entity.pays);
                    command.Parameters.AddWithValue("dateAjout", entity.dateAjout);

                    cnx.Open();

                    return command.ExecuteNonQuery() > 0;
                }
            }
        }

        public IEnumerable<Logement> GetByProprietaire(int idProprietaire)
        {
            using (SqlConnection cnx = new SqlConnection(ConnectionString))
            {
                using (SqlCommand command = cnx.CreateCommand())
                {
                    command.CommandText = "SELECT * FROM [Logement] WHERE [idProprietaire] = @id";
                    command.Parameters.AddWithValue("id", idProprietaire);
                    cnx.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            yield return reader.ToLogement();
                        }
                    }
                }
            }
        }

        public IEnumerable<Logement> GetByCategorie(int idCategorie)
        {
            using (SqlConnection cnx = new SqlConnection(ConnectionString))
            {
                using (SqlCommand command = cnx.CreateCommand())
                {
                    command.CommandText = "SELECT * FROM [Logement] WHERE [idCategorie] = @id";
                    command.Parameters.AddWithValue("id", idCategorie);
                    cnx.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            yield return reader.ToLogement();
                        }
                    }
                }
            }
        }
    }
}
