using System;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GestionTachesAdmin
{
    partial class FormCreationEmploye
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
            lblTitre = new Label();
            lblMatricule = new Label();
            txtMatricule = new TextBox();
            lblNom = new Label();
            txtNom = new TextBox();
            lblPrenom = new Label();
            txtPrenom = new TextBox();
            lblPoste = new Label();
            txtPoste = new TextBox();
            lblMotDePasse = new Label();
            txtMotDePasse = new TextBox();
            btnEnregistrer = new Button();
            dataGridViewEmployes = new DataGridView();
            label1 = new Label();
            btnSupprimer = new Button();
            btnUpdate = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmployes).BeginInit();
            SuspendLayout();
            // 
            // lblTitre
            // 
            lblTitre.AutoSize = true;
            lblTitre.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitre.Location = new Point(106, 9);
            lblTitre.Margin = new Padding(4, 0, 4, 0);
            lblTitre.Name = "lblTitre";
            lblTitre.Size = new Size(275, 32);
            lblTitre.TabIndex = 0;
            lblTitre.Text = "Création d'un Employé";
            // 
            // lblMatricule
            // 
            lblMatricule.AutoSize = true;
            lblMatricule.Location = new Point(53, 123);
            lblMatricule.Margin = new Padding(4, 0, 4, 0);
            lblMatricule.Name = "lblMatricule";
            lblMatricule.Size = new Size(78, 20);
            lblMatricule.TabIndex = 1;
            lblMatricule.Text = "Matricule :";
            // 
            // txtMatricule
            // 
            txtMatricule.Location = new Point(173, 118);
            txtMatricule.Margin = new Padding(4, 5, 4, 5);
            txtMatricule.Name = "txtMatricule";
            txtMatricule.Size = new Size(247, 27);
            txtMatricule.TabIndex = 2;
            // 
            // lblNom
            // 
            lblNom.AutoSize = true;
            lblNom.Location = new Point(53, 185);
            lblNom.Margin = new Padding(4, 0, 4, 0);
            lblNom.Name = "lblNom";
            lblNom.Size = new Size(49, 20);
            lblNom.TabIndex = 3;
            lblNom.Text = "Nom :";
            // 
            // txtNom
            // 
            txtNom.Location = new Point(173, 180);
            txtNom.Margin = new Padding(4, 5, 4, 5);
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(247, 27);
            txtNom.TabIndex = 4;
            // 
            // lblPrenom
            // 
            lblPrenom.AutoSize = true;
            lblPrenom.Location = new Point(53, 246);
            lblPrenom.Margin = new Padding(4, 0, 4, 0);
            lblPrenom.Name = "lblPrenom";
            lblPrenom.Size = new Size(67, 20);
            lblPrenom.TabIndex = 5;
            lblPrenom.Text = "Prénom :";
            // 
            // txtPrenom
            // 
            txtPrenom.Location = new Point(173, 242);
            txtPrenom.Margin = new Padding(4, 5, 4, 5);
            txtPrenom.Name = "txtPrenom";
            txtPrenom.Size = new Size(247, 27);
            txtPrenom.TabIndex = 6;
            // 
            // lblPoste
            // 
            lblPoste.AutoSize = true;
            lblPoste.Location = new Point(53, 308);
            lblPoste.Margin = new Padding(4, 0, 4, 0);
            lblPoste.Name = "lblPoste";
            lblPoste.Size = new Size(51, 20);
            lblPoste.TabIndex = 7;
            lblPoste.Text = "Poste :";
            // 
            // txtPoste
            // 
            txtPoste.Location = new Point(173, 303);
            txtPoste.Margin = new Padding(4, 5, 4, 5);
            txtPoste.Name = "txtPoste";
            txtPoste.Size = new Size(247, 27);
            txtPoste.TabIndex = 8;
            // 
            // lblMotDePasse
            // 
            lblMotDePasse.AutoSize = true;
            lblMotDePasse.Location = new Point(53, 369);
            lblMotDePasse.Margin = new Padding(4, 0, 4, 0);
            lblMotDePasse.Name = "lblMotDePasse";
            lblMotDePasse.Size = new Size(105, 20);
            lblMotDePasse.TabIndex = 9;
            lblMotDePasse.Text = "Mot de passe :";
            // 
            // txtMotDePasse
            // 
            txtMotDePasse.Location = new Point(173, 365);
            txtMotDePasse.Margin = new Padding(4, 5, 4, 5);
            txtMotDePasse.Name = "txtMotDePasse";
            txtMotDePasse.Size = new Size(247, 27);
            txtMotDePasse.TabIndex = 10;
            txtMotDePasse.UseSystemPasswordChar = true;
            // 
            // btnEnregistrer
            // 
            btnEnregistrer.Location = new Point(173, 431);
            btnEnregistrer.Margin = new Padding(4, 5, 4, 5);
            btnEnregistrer.Name = "btnEnregistrer";
            btnEnregistrer.Size = new Size(160, 54);
            btnEnregistrer.TabIndex = 11;
            btnEnregistrer.Text = "Enregistrer";
            btnEnregistrer.UseVisualStyleBackColor = true;
            btnEnregistrer.Click += btnEnregistrer_Click;
            // 
            // dataGridViewEmployes
            // 
            dataGridViewEmployes.AllowUserToAddRows = false;
            dataGridViewEmployes.AllowUserToDeleteRows = false;
            dataGridViewEmployes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewEmployes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEmployes.Location = new Point(447, 24);
            dataGridViewEmployes.Name = "dataGridViewEmployes";
            dataGridViewEmployes.RowHeadersVisible = false;
            dataGridViewEmployes.RowHeadersWidth = 51;
            dataGridViewEmployes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewEmployes.Size = new Size(552, 428);
            dataGridViewEmployes.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(630, -4);
            label1.Name = "label1";
            label1.Size = new Size(171, 25);
            label1.TabIndex = 13;
            label1.Text = "Liste des Employés";
            // 
            // btnSupprimer
            // 
            btnSupprimer.BackColor = SystemColors.ControlLight;
            btnSupprimer.Location = new Point(578, 474);
            btnSupprimer.Name = "btnSupprimer";
            btnSupprimer.Size = new Size(94, 29);
            btnSupprimer.TabIndex = 14;
            btnSupprimer.Text = "Supprimer";
            btnSupprimer.UseVisualStyleBackColor = false;
            btnSupprimer.Click += btnSupprimer_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.ControlLight;
            btnUpdate.Location = new Point(782, 474);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 15;
            btnUpdate.Text = "Modifier";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // FormCreationEmploye
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1011, 538);
            Controls.Add(btnUpdate);
            Controls.Add(btnSupprimer);
            Controls.Add(label1);
            Controls.Add(dataGridViewEmployes);
            Controls.Add(btnEnregistrer);
            Controls.Add(txtMotDePasse);
            Controls.Add(lblMotDePasse);
            Controls.Add(txtPoste);
            Controls.Add(lblPoste);
            Controls.Add(txtPrenom);
            Controls.Add(lblPrenom);
            Controls.Add(txtNom);
            Controls.Add(lblNom);
            Controls.Add(txtMatricule);
            Controls.Add(lblMatricule);
            Controls.Add(lblTitre);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormCreationEmploye";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ajouter un employé";
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmployes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label lblMatricule;
        private System.Windows.Forms.TextBox txtMatricule;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.Label lblPoste;
        private System.Windows.Forms.TextBox txtPoste;
        private System.Windows.Forms.Label lblMotDePasse;
        private System.Windows.Forms.TextBox txtMotDePasse;
        private System.Windows.Forms.Button btnEnregistrer;
        private DataGridView dataGridViewEmployes;
        private Label label1;
        
        private Button btnSupprimer;
        private Button btnUpdate;
    }
}