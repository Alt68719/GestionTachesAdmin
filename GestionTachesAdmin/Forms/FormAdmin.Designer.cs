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
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(201, 18);
            label1.TabIndex = 0;
            label1.Text = "Sélectionner un employé :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 137);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            label3.Location = new Point(12, 119);
            label3.Name = "label3";
            label3.Size = new Size(188, 18);
            label3.TabIndex = 2;
            label3.Text = "Sélectionner une tâche :";
            // 
            // cmbEmployes
            // 
            cmbEmployes.FlatStyle = FlatStyle.Flat;
            cmbEmployes.Font = new Font("Segoe UI", 11F);
            cmbEmployes.FormattingEnabled = true;
            cmbEmployes.Location = new Point(12, 55);
            cmbEmployes.Name = "cmbEmployes";
            cmbEmployes.Size = new Size(246, 33);
            cmbEmployes.TabIndex = 3;
            // 
            // cmbTaches
            // 
            cmbTaches.FlatStyle = FlatStyle.Flat;
            cmbTaches.Font = new Font("Segoe UI", 11F);
            cmbTaches.FormattingEnabled = true;
            cmbTaches.Location = new Point(12, 160);
            cmbTaches.Name = "cmbTaches";
            cmbTaches.Size = new Size(246, 33);
            cmbTaches.TabIndex = 4;
            // 
            // btnAttribuer
            // 
            btnAttribuer.BackColor = Color.FromArgb(0, 122, 204);
            btnAttribuer.Cursor = Cursors.Hand;
            btnAttribuer.FlatAppearance.BorderSize = 0;
            btnAttribuer.FlatAppearance.MouseOverBackColor = Color.Turquoise;
            btnAttribuer.FlatStyle = FlatStyle.Flat;
            btnAttribuer.Font = new Font("Verdana", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAttribuer.ForeColor = SystemColors.ActiveCaptionText;
            btnAttribuer.Location = new Point(52, 223);
            btnAttribuer.Name = "btnAttribuer";
            btnAttribuer.Size = new Size(148, 35);
            btnAttribuer.TabIndex = 5;
            btnAttribuer.Text = "Attribuer";
            btnAttribuer.UseVisualStyleBackColor = false;
            btnAttribuer.Click += btnAttribuer_Click;
            // 
            // dgvHistorique
            // 
            dgvHistorique.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHistorique.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistorique.Location = new Point(300, 32);
            dgvHistorique.Name = "dgvHistorique";
            dgvHistorique.ReadOnly = true;
            dgvHistorique.RowHeadersWidth = 51;
            dgvHistorique.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHistorique.Size = new Size(488, 413);
            dgvHistorique.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ButtonShadow;
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(367, 9);
            label4.Name = "label4";
            label4.Size = new Size(348, 20);
            label4.TabIndex = 7;
            label4.Text = "Historique récent des attributions et actions :";
            // 
            // FormAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(dgvHistorique);
            Controls.Add(btnAttribuer);
            Controls.Add(cmbTaches);
            Controls.Add(cmbEmployes);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormAdmin";
            Text = "Tableau de bord - Gestion des Tâches";
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