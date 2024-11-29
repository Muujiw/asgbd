using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class DatabaseManager
    {
        // Chaîne de connexion
        private readonly string connectionString;

        public DatabaseManager(string server, string database, string username, string password)
        {
            connectionString = $"Server={server};Database={database};Uid={username};Pwd={password};";
        }

        // Méthode pour obtenir une connexion MySQL
        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }

        // Exemple : Méthode pour exécuter une requête SQL
        public void ExecuteQuery(string query)
        {
            using (var connection = GetConnection())
            {
                try
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.ExecuteNonQuery();
                    Console.WriteLine("Requête exécutée avec succès !");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erreur lors de l'exécution de la requête : " + ex.Message);
                }
            }
        }

        // Exemple : Méthode pour récupérer des données
        public DataTable FetchData(string query)
        {
            DataTable dataTable = new DataTable();

            using (var connection = GetConnection())
            {
                try
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(dataTable);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erreur lors de la récupération des données : " + ex.Message);
                }
            }

            return dataTable;
        }
    }
}
