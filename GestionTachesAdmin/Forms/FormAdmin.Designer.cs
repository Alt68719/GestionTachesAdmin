using System;
using System.Drawing;
using System.Windows.Forms;

namespace GestionTachesAdmin
{
    partial class FormAdmin
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            cmbEmployes = new ComboBox();
            cmbTaches = new ComboBox();
            btnAttribuer = new Button();
            dgvHistorique = new DataGridView();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvHistorique).BeginInit();
            SuspendLayout();

            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(40, 50, 70);
            label1.Location = new Point(30, 40);
            label1.Name = "label1";
            label1.Size = new Size(198, 23);
            label1.TabIndex = 0;
            label1.Text = "Sélectionner un employé :";

            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 100);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 1;

            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(40, 50, 70);
            label3.Location = new Point(30, 130);
            label3.Name = "label3";
            label3.Size = new Size(187, 23);
            label3.TabIndex = 2;
            label3.Text = "Sélectionner une tâche :";

            // 
            // cmbEmployes
            // 
            cmbEmployes.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEmployes.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            cmbEmployes.FormattingEnabled = true;
            cmbEmployes.Location = new Point(30, 70);
            cmbEmployes.Name = "cmbEmployes";
            cmbEmployes.Size = new Size(260, 31);
            cmbEmployes.TabIndex = 3;

            // 
            // cmbTaches
            // 
            cmbTaches.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTaches.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            cmbTaches.FormattingEnabled = true;
            cmbTaches.Location = new Point(30, 160);
            cmbTaches.Name = "cmbTaches";
            cmbTaches.Size = new Size(260, 31);
            cmbTaches.TabIndex = 4;

            // 
            // btnAttribuer
            // 
            btnAttribuer.BackColor = Color.FromArgb(0, 122, 204);
            btnAttribuer.Cursor = Cursors.Hand;
            btnAttribuer.FlatAppearance.BorderSize = 0;
            btnAttribuer.FlatStyle = FlatStyle.Flat;
            btnAttribuer.Font = new System.Drawing.Font("Segoe UI", 11F, FontStyle.Bold);
            btnAttribuer.ForeColor = Color.White;
            btnAttribuer.Location = new Point(30, 220);
            btnAttribuer.Name = "btnAttribuer";
            btnAttribuer.Size = new Size(260, 45);
            btnAttribuer.TabIndex = 5;
            btnAttribuer.Text = "Attribuer la tâche";
            btnAttribuer.UseVisualStyleBackColor = false;
            btnAttribuer.Click += btnAttribuer_Click;

            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 12F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(40, 50, 70);
            label4.Location = new Point(320, 35);
            label4.Name = "label4";
            label4.Size = new Size(378, 28);
            label4.TabIndex = 7;
            label4.Text = "Historique des attributions et actions :";

            // 
            // dgvHistorique
            // 
            dgvHistorique.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHistorique.BackgroundColor = Color.White;
            dgvHistorique.BorderStyle = BorderStyle.None;
            dgvHistorique.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistorique.Location = new Point(320, 70);
            dgvHistorique.Name = "dgvHistorique";
            dgvHistorique.ReadOnly = true;
            dgvHistorique.RowHeadersWidth = 51;
            dgvHistorique.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHistorique.Size = new Size(530, 380);
            dgvHistorique.TabIndex = 6;

            // 
            // FormAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(880, 480);
            Controls.Add(label4);
            Controls.Add(dgvHistorique);
            Controls.Add(btnAttribuer);
            Controls.Add(cmbTaches);
            Controls.Add(cmbEmployes);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FormAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tableau de bord - Attribution et Historique";
            Load += FormAdmin_Load;
            ((System.ComponentModel.ISupportInitialize)dgvHistorique).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cmbEmployes;
        private ComboBox cmbTaches;
        private Button btnAttribuer;
        private DataGridView dgvHistorique;
        private Label label4;
    }
}