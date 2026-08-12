namespace GestionTachesAdmin.Forms
{
    partial class FormCommentaireEmp
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            cmbTaches = new ComboBox();
            txtNouveauCommentaire = new TextBox();
            btnEnvoyerCommentaire = new Button();
            lstCommentaires = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // cmbTaches
            // 
            cmbTaches.FormattingEnabled = true;
            cmbTaches.Location = new Point(212, 42);
            cmbTaches.Margin = new Padding(4, 5, 4, 5);
            cmbTaches.Name = "cmbTaches";
            cmbTaches.Size = new Size(816, 28);
            cmbTaches.TabIndex = 0;
            cmbTaches.SelectedIndexChanged += cmbTaches_SelectedIndexChanged_1;
            // 
            // txtNouveauCommentaire
            // 
            txtNouveauCommentaire.Location = new Point(30, 416);
            txtNouveauCommentaire.Margin = new Padding(4, 5, 4, 5);
            txtNouveauCommentaire.Multiline = true;
            txtNouveauCommentaire.Name = "txtNouveauCommentaire";
            txtNouveauCommentaire.Size = new Size(998, 84);
            txtNouveauCommentaire.TabIndex = 2;
            // 
            // btnEnvoyerCommentaire
            // 
            btnEnvoyerCommentaire.Location = new Point(908, 543);
            btnEnvoyerCommentaire.Margin = new Padding(4, 5, 4, 5);
            btnEnvoyerCommentaire.Name = "btnEnvoyerCommentaire";
            btnEnvoyerCommentaire.Size = new Size(120, 32);
            btnEnvoyerCommentaire.TabIndex = 3;
            btnEnvoyerCommentaire.Text = "Envoyer";
            btnEnvoyerCommentaire.UseVisualStyleBackColor = true;
            btnEnvoyerCommentaire.Click += btnEnvoyerCommentaire_Click_1;
            // 
            // lstCommentaires
            // 
            lstCommentaires.FormattingEnabled = true;
            lstCommentaires.Location = new Point(30, 131);
            lstCommentaires.Margin = new Padding(4, 5, 4, 5);
            lstCommentaires.Name = "lstCommentaires";
            lstCommentaires.Size = new Size(998, 244);
            lstCommentaires.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkSlateGray;
            label1.Location = new Point(24, 44);
            label1.Name = "label1";
            label1.Size = new Size(181, 21);
            label1.TabIndex = 4;
            label1.Text = "Listes des Taches :";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkSlateGray;
            label2.Location = new Point(24, 106);
            label2.Name = "label2";
            label2.Size = new Size(187, 21);
            label2.TabIndex = 5;
            label2.Text = "Les Commentaires :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DarkSlateGray;
            label3.Location = new Point(30, 390);
            label3.Name = "label3";
            label3.Size = new Size(252, 21);
            label3.TabIndex = 6;
            label3.Text = "Entrer votre Commentaire :";
            // 
            // FormCommentaireEmp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1041, 612);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnEnvoyerCommentaire);
            Controls.Add(txtNouveauCommentaire);
            Controls.Add(lstCommentaires);
            Controls.Add(cmbTaches);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormCommentaireEmp";
            Text = "FormCommentaireEmp";
            Load += FormCommentaireEmp_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTaches;
        private System.Windows.Forms.TextBox txtNouveauCommentaire;
        private System.Windows.Forms.Button btnEnvoyerCommentaire;
        private System.Windows.Forms.ListBox lstCommentaires;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}