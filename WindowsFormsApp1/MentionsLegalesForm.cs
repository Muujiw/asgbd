using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MentionsLegalesForm : Form
    {
        public MentionsLegalesForm()
        {
            InitializeComponent();
        }

        private void MentionsLegalesForm_Load(object sender, EventArgs e)
        {
            try
            {
                // Charger les mentions légales depuis le fichier
                string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "mentions.txt");

                if (!File.Exists(filePath))
                {
                    MessageBox.Show("Le fichier mentions.txt est introuvable.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string mentionsLegales = File.ReadAllText(filePath, Encoding.Default);

                // Afficher les mentions légales dans le RichTextBox
                richTextBoxMentions.Text = mentionsLegales;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Une erreur est survenue : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
