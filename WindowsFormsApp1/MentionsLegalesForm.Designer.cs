namespace WindowsFormsApp1
{
    partial class MentionsLegalesForm
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
            this.richTextBoxMentions = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // richTextBoxMentions
            // 
            this.richTextBoxMentions.Location = new System.Drawing.Point(12, 12);
            this.richTextBoxMentions.Name = "richTextBoxMentions";
            this.richTextBoxMentions.Size = new System.Drawing.Size(856, 634);
            this.richTextBoxMentions.TabIndex = 0;
            this.richTextBoxMentions.Text = "";
            this.richTextBoxMentions.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // MentionsLegalesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 646);
            this.Controls.Add(this.richTextBoxMentions);
            this.Name = "MentionsLegalesForm";
            this.Text = "MentionsLegalesForm";
            this.Load += new System.EventHandler(this.MentionsLegalesForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxMentions;
    }
}