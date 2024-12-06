using Org.BouncyCastle.Crypto.Generators;
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
    public partial class Form1 : Form
    {
        private DatabaseManager dbManager;
        public Form1()
        {
            InitializeComponent();

            dbManager = new DatabaseManager("localhost", "asg_database", "root", "");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void loginTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(loginTextBox.Text) || string.IsNullOrEmpty(passwordTextBox.Text))
            {
                MessageBox.Show("Veuillez remplir tous les champs !");
                return;
            }

            string username = loginTextBox.Text;
            string password = passwordTextBox.Text;

            // password is hashed with BCRYPT, so we need to hash the input password before comparing
            string query = $"SELECT * FROM users WHERE email='{username}'";
            var userData = dbManager.FetchData(query);
            string name = userData.Rows[0]["name"].ToString();

            if (userData != null && userData.Rows.Count > 0)
            {
                string storedHashedPassword = userData.Rows[0]["password"].ToString();

                // Vérifier le mot de passe haché
                if (BCrypt.Net.BCrypt.Verify(password, storedHashedPassword))
                {
                    // close the login form and open the main form
                    this.Hide();
                    new Form2(name).Show();
                }
                else
                {
                    MessageBox.Show("Nom d'utilisateur ou mot de passe incorrect.");
                }
            }
            else
            {
                MessageBox.Show("Nom d'utilisateur ou mot de passe incorrect.");
            }
        }

    }
}
