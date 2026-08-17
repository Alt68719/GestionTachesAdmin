namespace GestionTachesAdmin.Forms
{
    partial class FormMenuEmploye
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
            tabControl1 = new TabControl();
            tabLstes = new TabPage();
            label1 = new Label();
            dataGridViewTaches = new DataGridView();
            panel1 = new Panel();
            tabCommentaire = new TabPage();
            tabNotification = new TabPage();
            dataGridViewNotif = new DataGridView();
            tabControl1.SuspendLayout();
            tabLstes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTaches).BeginInit();
            tabNotification.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewNotif).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabLstes);
            tabControl1.Controls.Add(tabCommentaire);
            tabControl1.Controls.Add(tabNotification);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Margin = new Padding(4, 5, 4, 5);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1067, 692);
            tabControl1.TabIndex = 0;
            // 
            // tabLstes
            // 
            tabLstes.Controls.Add(label1);
            tabLstes.Controls.Add(dataGridViewTaches);
            tabLstes.Controls.Add(panel1);
            tabLstes.Location = new Point(4, 29);
            tabLstes.Margin = new Padding(4, 5, 4, 5);
            tabLstes.Name = "tabLstes";
            tabLstes.Padding = new Padding(4, 5, 4, 5);
            tabLstes.Size = new Size(1059, 659);
            tabLstes.TabIndex = 0;
            tabLstes.Text = "Listes des taches";
            tabLstes.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Gainsboro;
            label1.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkSlateGray;
            label1.Location = new Point(393, 20);
            label1.Name = "label1";
            label1.Size = new Size(248, 27);
            label1.TabIndex = 1;
            label1.Text = "LISTEA DES TACHES";
            // 
            // dataGridViewTaches
            // 
            dataGridViewTaches.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTaches.Dock = DockStyle.Bottom;
            dataGridViewTaches.Location = new Point(4, 63);
            dataGridViewTaches.Margin = new Padding(4, 5, 4, 5);
            dataGridViewTaches.Name = "dataGridViewTaches";
            dataGridViewTaches.RowHeadersWidth = 51;
            dataGridViewTaches.Size = new Size(1051, 591);
            dataGridViewTaches.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.Location = new Point(0, 13);
            panel1.Name = "panel1";
            panel1.Size = new Size(1056, 42);
            panel1.TabIndex = 2;
            // 
            // tabCommentaire
            // 
            tabCommentaire.Location = new Point(4, 29);
            tabCommentaire.Margin = new Padding(4, 5, 4, 5);
            tabCommentaire.Name = "tabCommentaire";
            tabCommentaire.Padding = new Padding(4, 5, 4, 5);
            tabCommentaire.Size = new Size(1059, 659);
            tabCommentaire.TabIndex = 1;
            tabCommentaire.Text = "Commentaire";
            tabCommentaire.UseVisualStyleBackColor = true;
            // 
            // tabNotification
            // 
            tabNotification.Controls.Add(dataGridViewNotif);
            tabNotification.Location = new Point(4, 29);
            tabNotification.Margin = new Padding(4, 5, 4, 5);
            tabNotification.Name = "tabNotification";
            tabNotification.Size = new Size(1059, 659);
            tabNotification.TabIndex = 2;
            tabNotification.Text = "Notification";
            tabNotification.UseVisualStyleBackColor = true;
            // 
            // dataGridViewNotif
            // 
            dataGridViewNotif.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewNotif.Location = new Point(3, 87);
            dataGridViewNotif.Name = "dataGridViewNotif";
            dataGridViewNotif.RowHeadersWidth = 51;
            dataGridViewNotif.Size = new Size(1053, 569);
            dataGridViewNotif.TabIndex = 0;
            // 
            // FormMenuEmploye
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1067, 692);
            Controls.Add(tabControl1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormMenuEmploye";
            Text = "FormMenuEmploye";
            FormClosed += FormAdmin_FormClosed;
            tabControl1.ResumeLayout(false);
            tabLstes.ResumeLayout(false);
            tabLstes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTaches).EndInit();
            tabNotification.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewNotif).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabLstes;
        private System.Windows.Forms.DataGridView dataGridViewTaches;
        private System.Windows.Forms.TabPage tabCommentaire;
        private System.Windows.Forms.TabPage tabNotification;
        private Label label1;
        private Panel panel1;
        private DataGridView dataGridViewNotif;
    }
}