namespace WindowsFormsApp1
{
    partial class LogoutButton
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.refreshFromDatabaseButton = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.deleteUserFromIDButton = new System.Windows.Forms.Button();
            this.updateDatabaseFromDataGridViewButton = new System.Windows.Forms.Button();
            this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.deleteFormationFromIDButton = new System.Windows.Forms.Button();
            this.updateDBFromdataGridViewFormations = new System.Windows.Forms.Button();
            this.dataGridViewFormations = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.LogoutButton1 = new System.Windows.Forms.Button();
            this.refreshFromDatabaseButton.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFormations)).BeginInit();
            this.SuspendLayout();
            // 
            // refreshFromDatabaseButton
            // 
            this.refreshFromDatabaseButton.Controls.Add(this.tabPage1);
            this.refreshFromDatabaseButton.Controls.Add(this.tabPage2);
            this.refreshFromDatabaseButton.Location = new System.Drawing.Point(27, 63);
            this.refreshFromDatabaseButton.Name = "refreshFromDatabaseButton";
            this.refreshFromDatabaseButton.SelectedIndex = 0;
            this.refreshFromDatabaseButton.Size = new System.Drawing.Size(1238, 566);
            this.refreshFromDatabaseButton.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.deleteUserFromIDButton);
            this.tabPage1.Controls.Add(this.updateDatabaseFromDataGridViewButton);
            this.tabPage1.Controls.Add(this.dataGridViewUsers);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1230, 540);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Gestion";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(779, 511);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "ID :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(820, 508);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(24, 20);
            this.textBox1.TabIndex = 3;
            // 
            // deleteUserFromIDButton
            // 
            this.deleteUserFromIDButton.Location = new System.Drawing.Point(873, 506);
            this.deleteUserFromIDButton.Name = "deleteUserFromIDButton";
            this.deleteUserFromIDButton.Size = new System.Drawing.Size(156, 23);
            this.deleteUserFromIDButton.TabIndex = 2;
            this.deleteUserFromIDButton.Text = "Supprimer l\'utilisateur";
            this.deleteUserFromIDButton.UseVisualStyleBackColor = true;
            this.deleteUserFromIDButton.Click += new System.EventHandler(this.deleteUserFromIDButton_Click);
            // 
            // updateDatabaseFromDataGridViewButton
            // 
            this.updateDatabaseFromDataGridViewButton.Location = new System.Drawing.Point(0, 497);
            this.updateDatabaseFromDataGridViewButton.Name = "updateDatabaseFromDataGridViewButton";
            this.updateDatabaseFromDataGridViewButton.Size = new System.Drawing.Size(554, 47);
            this.updateDatabaseFromDataGridViewButton.TabIndex = 1;
            this.updateDatabaseFromDataGridViewButton.Text = "Mettre à jour";
            this.updateDatabaseFromDataGridViewButton.UseVisualStyleBackColor = true;
            this.updateDatabaseFromDataGridViewButton.Click += new System.EventHandler(this.updateDatabaseFromDataGridViewButton_Click_1);
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsers.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.Size = new System.Drawing.Size(1230, 500);
            this.dataGridViewUsers.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Controls.Add(this.deleteFormationFromIDButton);
            this.tabPage2.Controls.Add(this.updateDBFromdataGridViewFormations);
            this.tabPage2.Controls.Add(this.dataGridViewFormations);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1230, 540);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Formations";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(782, 511);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "ID :";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(823, 508);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(24, 20);
            this.textBox2.TabIndex = 7;
            // 
            // deleteFormationFromIDButton
            // 
            this.deleteFormationFromIDButton.Location = new System.Drawing.Point(876, 506);
            this.deleteFormationFromIDButton.Name = "deleteFormationFromIDButton";
            this.deleteFormationFromIDButton.Size = new System.Drawing.Size(156, 23);
            this.deleteFormationFromIDButton.TabIndex = 6;
            this.deleteFormationFromIDButton.Text = "Supprimer la formation";
            this.deleteFormationFromIDButton.UseVisualStyleBackColor = true;
            this.deleteFormationFromIDButton.Click += new System.EventHandler(this.deleteFormationFromIDButton_Click);
            // 
            // updateDBFromdataGridViewFormations
            // 
            this.updateDBFromdataGridViewFormations.Location = new System.Drawing.Point(3, 497);
            this.updateDBFromdataGridViewFormations.Name = "updateDBFromdataGridViewFormations";
            this.updateDBFromdataGridViewFormations.Size = new System.Drawing.Size(554, 47);
            this.updateDBFromdataGridViewFormations.TabIndex = 5;
            this.updateDBFromdataGridViewFormations.Text = "Mettre à jour";
            this.updateDBFromdataGridViewFormations.UseVisualStyleBackColor = true;
            this.updateDBFromdataGridViewFormations.Click += new System.EventHandler(this.updateDBFromdataGridViewFormations_Click);
            // 
            // dataGridViewFormations
            // 
            this.dataGridViewFormations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFormations.Location = new System.Drawing.Point(3, 0);
            this.dataGridViewFormations.Name = "dataGridViewFormations";
            this.dataGridViewFormations.Size = new System.Drawing.Size(1230, 500);
            this.dataGridViewFormations.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(263, 36);
            this.label1.MaximumSize = new System.Drawing.Size(200, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bonjour, ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(724, 16);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(339, 53);
            this.button3.TabIndex = 1;
            this.button3.Text = "Rafraichir depuis la base de données";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // LogoutButton1
            // 
            this.LogoutButton1.Location = new System.Drawing.Point(-1, 0);
            this.LogoutButton1.Name = "LogoutButton1";
            this.LogoutButton1.Size = new System.Drawing.Size(94, 23);
            this.LogoutButton1.TabIndex = 2;
            this.LogoutButton1.Text = "Déconnexion";
            this.LogoutButton1.UseVisualStyleBackColor = true;
            this.LogoutButton1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LogoutButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1264, 655);
            this.Controls.Add(this.LogoutButton1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.refreshFromDatabaseButton);
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Name = "LogoutButton";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.refreshFromDatabaseButton.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFormations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl refreshFromDatabaseButton;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewUsers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button deleteUserFromIDButton;
        private System.Windows.Forms.Button updateDatabaseFromDataGridViewButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button deleteFormationFromIDButton;
        private System.Windows.Forms.Button updateDBFromdataGridViewFormations;
        private System.Windows.Forms.DataGridView dataGridViewFormations;
        private System.Windows.Forms.Button LogoutButton1;
    }
}