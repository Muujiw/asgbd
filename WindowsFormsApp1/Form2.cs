using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        private String loggedInUser;
        private DatabaseManager dbManager;
        public Form2(string loggedInUser)
        {
            InitializeComponent();
            dbManager = new DatabaseManager("localhost", "asg_database", "root", "");
            this.loggedInUser = loggedInUser;
            // concatener le texte de label1
            label1.Text += loggedInUser;
            label1.Text += " !";
            LoadData();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }



        private void LoadData()
        {
            // Charger les utilisateurs
            string userQuery = "SELECT id, name, email, adresse, code_postal, ville, date_embauche, domaine_assurance, role, password FROM users";
            DataTable users = dbManager.FetchData(userQuery);
            dataGridViewUsers.DataSource = users;

            // Charger les formations
            string formationQuery = "SELECT id, nom_formation, date_debut, date_fin, domaine_formation, formateur_id, nombre_max_participants, created_at, updated_at FROM formations";
            DataTable formations = dbManager.FetchData(formationQuery);
            dataGridViewFormations.DataSource = formations;
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void updateDatabaseFromDataGridViewButton_Click_1(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewUsers.Rows)
            {
                // Ignorer les lignes qui ne sont pas valides
                if (row.IsNewRow || row.Cells["id"].Value == null) continue;

                try
                {
                    // Récupérer les valeurs des cellules
                    int id = Convert.ToInt32(row.Cells["id"].Value);
                    string name = row.Cells["name"].Value?.ToString();
                    string email = row.Cells["email"].Value?.ToString();
                    string adresse = row.Cells["adresse"].Value?.ToString();
                    string codePostal = row.Cells["code_postal"].Value?.ToString();
                    string ville = row.Cells["ville"].Value?.ToString();
                    DateTime? dateEmbauche = row.Cells["date_embauche"].Value as DateTime?;
                    string domaineAssurance = row.Cells["domaine_assurance"].Value?.ToString();
                    string role = row.Cells["role"].Value?.ToString();
                    string password = row.Cells["password"].Value?.ToString();
                    string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);

                    // Vérifier si l'ID existe déjà dans la base de données
                    string idQuery = "SELECT COUNT(*) FROM users WHERE id = @id";
                    var idCountTable = dbManager.FetchDataWithParameters(idQuery, new MySqlParameter("@id", id));

                    if (idCountTable.Rows.Count > 0 && Convert.ToInt32(idCountTable.Rows[0][0]) == 0)
                    {
                        // Insérer un nouvel utilisateur
                        string insertQuery = @"
                    INSERT INTO users (id, name, email, adresse, code_postal, ville, date_embauche, domaine_assurance, role, service_id, password) 
                    VALUES (@id, @name, @email, @adresse, @codePostal, @ville, @dateEmbauche, @domaineAssurance, @role, 1, @password)";

                        dbManager.ExecuteQueryWithParameters(insertQuery, new[]
                        {
                    new MySqlParameter("@id", id),
                    new MySqlParameter("@name", name),
                    new MySqlParameter("@email", email),
                    new MySqlParameter("@adresse", adresse),
                    new MySqlParameter("@codePostal", codePostal),
                    new MySqlParameter("@ville", ville),
                    new MySqlParameter("@dateEmbauche", (object)dateEmbauche?.ToString("yyyy-MM-dd") ?? DBNull.Value),
                    new MySqlParameter("@domaineAssurance", domaineAssurance),
                    new MySqlParameter("@role", role),
                    new MySqlParameter("@password", hashedPassword)
                });
                    }
                    else
                    {
                        // Mettre à jour un utilisateur existant
                        string updateQuery = @"
                    UPDATE users
                    SET 
                        name = @name, 
                        email = @email, 
                        adresse = @adresse, 
                        code_postal = @codePostal, 
                        ville = @ville, 
                        date_embauche = @dateEmbauche,
                        domaine_assurance = @domaineAssurance, 
                        role = @role,
                        service_id = 1,
                        password = @password
                    WHERE id = @id";

                        dbManager.ExecuteQueryWithParameters(updateQuery, new[]
                        {
                    new MySqlParameter("@id", id),
                    new MySqlParameter("@name", name),
                    new MySqlParameter("@email", email),
                    new MySqlParameter("@adresse", adresse),
                    new MySqlParameter("@codePostal", codePostal),
                    new MySqlParameter("@ville", ville),
                    new MySqlParameter("@dateEmbauche", (object)dateEmbauche?.ToString("yyyy-MM-dd") ?? DBNull.Value),
                    new MySqlParameter("@domaineAssurance", domaineAssurance),
                    new MySqlParameter("@role", role),
                    new MySqlParameter("@password", password)
                });
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erreur lors de la mise à jour de l'utilisateur ID {row.Cells["id"].Value}: {ex.Message}");
                }

  
            }

            MessageBox.Show("Mise à jour effectuée avec succès !");
        }


        private void button3_Click(object sender, EventArgs e)
        {
            LoadData();
            MessageBox.Show("Données rechargées avec succès !");
        }

        private void deleteUserFromIDButton_Click(object sender, EventArgs e)
        {
            // Vérifier si la textbox contient un ID valide
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Veuillez entrer un ID !");
                return;
            }

            if (!int.TryParse(textBox1.Text, out int userId))
            {
                MessageBox.Show("L'ID doit être un nombre valide !");
                return;
            }

            // Demander confirmation avant suppression
            DialogResult result = MessageBox.Show(
                $"Êtes-vous sûr de vouloir supprimer l'utilisateur avec l'ID {userId} ?",
                "Confirmation de suppression",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                try
                {
                    // Requête SQL pour supprimer l'utilisateur
                    string deleteQuery = "DELETE FROM users WHERE id = @id";

                    dbManager.ExecuteQueryWithParameters(deleteQuery, new[]
                    {
                new MySqlParameter("@id", userId)
            });

                    MessageBox.Show("Utilisateur supprimé avec succès !");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erreur lors de la suppression de l'utilisateur : {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Suppression annulée.");
            }
        }

        private void deleteFormationFromIDButton_Click(object sender, EventArgs e)
        {
            // Vérifier si la textbox contient un ID valide
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Veuillez entrer un ID !");
                return;
            }

            if (!int.TryParse(textBox2.Text, out int formationId))
            {
                MessageBox.Show("L'ID doit être un nombre valide !");
                return;
            }

            // Demander confirmation avant suppression
            DialogResult result = MessageBox.Show(
                $"Êtes-vous sûr de vouloir supprimer la formation avec l'ID {formationId} ?",
                "Confirmation de suppression",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                try
                {
                    // Requête SQL pour supprimer la formation
                    string deleteQuery = "DELETE FROM formations WHERE id = @id";

                    dbManager.ExecuteQueryWithParameters(deleteQuery, new[]
                    {
                new MySqlParameter("@id", formationId)
            });

                    MessageBox.Show("Formation supprimée avec succès !");
                    LoadData(); // Recharger les données après suppression
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erreur lors de la suppression de la formation : {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Suppression annulée.");
            }
        }


        private void updateDBFromdataGridViewFormations_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewFormations.Rows)
            {
                // Ignorer les lignes qui ne sont pas valides
                if (row.IsNewRow || row.Cells["id"].Value == null) continue;

                try
                {
                    // Récupérer les valeurs des cellules
                    int id = Convert.ToInt32(row.Cells["id"].Value);
                    string nomFormation = row.Cells["nom_formation"].Value?.ToString();
                    DateTime? dateDebut = row.Cells["date_debut"].Value as DateTime?;
                    DateTime? dateFin = row.Cells["date_fin"].Value as DateTime?;
                    string domaineFormation = row.Cells["domaine_formation"].Value?.ToString();
                    int formateurId = Convert.ToInt32(row.Cells["formateur_id"].Value);
                    int maxParticipants = Convert.ToInt32(row.Cells["nombre_max_participants"].Value);

                    // Vérification de la concordance des dates
                    if (dateDebut.HasValue && dateFin.HasValue && dateDebut.Value > dateFin.Value)
                    {
                        MessageBox.Show($"Erreur : La date de début ({dateDebut.Value:yyyy-MM-dd}) est postérieure à la date de fin ({dateFin.Value:yyyy-MM-dd}) pour la formation ID {id}.");
                        continue; // Passer à la ligne suivante sans effectuer de mise à jour
                    }

                    // Vérifier si l'ID existe déjà dans la base de données
                    string idQuery = "SELECT COUNT(*) FROM formations WHERE id = @id";
                    var idCountTable = dbManager.FetchDataWithParameters(idQuery, new MySqlParameter("@id", id));

                    if (idCountTable.Rows.Count > 0 && Convert.ToInt32(idCountTable.Rows[0][0]) == 0)
                    {
                        // Insérer une nouvelle formation
                        string insertQuery = @"
                    INSERT INTO formations (id, nom_formation, date_debut, date_fin, domaine_formation, formateur_id, nombre_max_participants) 
                    VALUES (@id, @nomFormation, @dateDebut, @dateFin, @domaineFormation, @formateurId, @maxParticipants)";

                        dbManager.ExecuteQueryWithParameters(insertQuery, new[]
                        {
                    new MySqlParameter("@id", id),
                    new MySqlParameter("@nomFormation", nomFormation),
                    new MySqlParameter("@dateDebut", (object)dateDebut?.ToString("yyyy-MM-dd") ?? DBNull.Value),
                    new MySqlParameter("@dateFin", (object)dateFin?.ToString("yyyy-MM-dd") ?? DBNull.Value),
                    new MySqlParameter("@domaineFormation", domaineFormation),
                    new MySqlParameter("@formateurId", formateurId),
                    new MySqlParameter("@maxParticipants", maxParticipants)
                });
                    }
                    else
                    {
                        // Mettre à jour une formation existante
                        string updateQuery = @"
                    UPDATE formations
                    SET 
                        nom_formation = @nomFormation, 
                        date_debut = @dateDebut, 
                        date_fin = @dateFin, 
                        domaine_formation = @domaineFormation, 
                        formateur_id = @formateurId, 
                        nombre_max_participants = @maxParticipants
                    WHERE id = @id";

                        dbManager.ExecuteQueryWithParameters(updateQuery, new[]
                        {
                    new MySqlParameter("@id", id),
                    new MySqlParameter("@nomFormation", nomFormation),
                    new MySqlParameter("@dateDebut", (object)dateDebut?.ToString("yyyy-MM-dd") ?? DBNull.Value),
                    new MySqlParameter("@dateFin", (object)dateFin?.ToString("yyyy-MM-dd") ?? DBNull.Value),
                    new MySqlParameter("@domaineFormation", domaineFormation),
                    new MySqlParameter("@formateurId", formateurId),
                    new MySqlParameter("@maxParticipants", maxParticipants)
                });
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erreur lors de la mise à jour de la formation ID {row.Cells["id"].Value}: {ex.Message}");
                }
            }

            MessageBox.Show("Mise à jour des formations effectuée avec succès !");
        }



    }
}
