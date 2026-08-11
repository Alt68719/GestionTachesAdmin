namespace GestionTachesAdmin.Forms
{
    partial class FormMenuEmploye
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            tabControl1 = new TabControl();
            tabLstes = new TabPage();
            panel1 = new Panel();
            label1 = new Label();
            dataGridViewTaches = new DataGridView();
            tabCommentaire = new TabPage();
            tabNotification = new TabPage();
            tabControl1.SuspendLayout();
            tabLstes.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTaches).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabLstes);
            tabControl1.Controls.Add(tabCommentaire);
            tabControl1.Controls.Add(tabNotification);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 450);
            tabControl1.TabIndex = 5;
            // 
            // tabLstes
            // 
            tabLstes.Controls.Add(panel1);
            tabLstes.Controls.Add(dataGridViewTaches);
            tabLstes.Location = new Point(4, 29);
            tabLstes.Name = "tabLstes";
            tabLstes.Padding = new Padding(3);
            tabLstes.Size = new Size(792, 417);
            tabLstes.TabIndex = 0;
            tabLstes.Text = "Listes des taches";
            tabLstes.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(786, 46);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkSlateGray;
            label1.Location = new Point(291, 9);
            label1.Name = "label1";
            label1.Size = new Size(223, 27);
            label1.TabIndex = 0;
            label1.Text = "Listes des taches";
            // 
            // dataGridViewTaches
            // 
            dataGridViewCellStyle1.BackColor = Color.Gainsboro;
            dataGridViewCellStyle1.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.Aquamarine;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ActiveCaptionText;
            dataGridViewTaches.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewTaches.Anchor = AnchorStyles.None;
            dataGridViewTaches.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewTaches.BackgroundColor = Color.WhiteSmoke;
            dataGridViewTaches.BorderStyle = BorderStyle.None;
            dataGridViewTaches.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewTaches.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.Blue;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewTaches.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewTaches.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.DimGray;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.LightGray;
            dataGridViewCellStyle3.Padding = new Padding(8, 0, 8, 0);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(224, 231, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(30, 41, 59);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridViewTaches.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewTaches.EnableHeadersVisualStyles = false;
            dataGridViewTaches.GridColor = Color.FromArgb(235, 237, 240);
            dataGridViewTaches.Location = new Point(3, 55);
            dataGridViewTaches.Name = "dataGridViewTaches";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridViewTaches.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewTaches.RowHeadersVisible = false;
            dataGridViewTaches.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle5.SelectionBackColor = Color.DarkTurquoise;
            dataGridViewCellStyle5.SelectionForeColor = Color.MediumBlue;
            dataGridViewTaches.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewTaches.Size = new Size(786, 359);
            dataGridViewTaches.TabIndex = 1;
            dataGridViewTaches.CellContentClick += dataGridViewTaches_CellContentClick;
            // 
            // tabCommentaire
            // 
            tabCommentaire.Location = new Point(4, 29);
            tabCommentaire.Name = "tabCommentaire";
            tabCommentaire.Padding = new Padding(3);
            tabCommentaire.Size = new Size(792, 417);
            tabCommentaire.TabIndex = 1;
            tabCommentaire.Text = "Commentaire";
            tabCommentaire.UseVisualStyleBackColor = true;
            // 
            // tabNotification
            // 
            tabNotification.Location = new Point(4, 29);
            tabNotification.Name = "tabNotification";
            tabNotification.Size = new Size(792, 417);
            tabNotification.TabIndex = 2;
            tabNotification.Text = "Notification";
            tabNotification.UseVisualStyleBackColor = true;
            // 
            // FormMenuEmploye
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "FormMenuEmploye";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormMenuEmploye";
            Load += FormAdmin_load;
            tabControl1.ResumeLayout(false);
            tabLstes.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTaches).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TabControl tabControl1;
        private TabPage tabLstes;
        private TabPage tabCommentaire;
        private TabPage tabNotification;
        private DataGridView dataGridViewTaches;
        private Panel panel1;
        private Label label1;
    }
}