using System.Drawing;
namespace GestionTachesAdmin.Forms
{
    partial class FormCommentaire
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
            dgvCommentaire = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvCommentaire).BeginInit();
            SuspendLayout();
            // 
            // dgvCommentaire
            // 
            dgvCommentaire.AllowUserToAddRows = false;
            dgvCommentaire.AllowUserToDeleteRows = false;
            dgvCommentaire.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(248, 249, 251);
            dgvCommentaire.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvCommentaire.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCommentaire.BackgroundColor = Color.White;
            dgvCommentaire.BorderStyle = BorderStyle.None;
            dgvCommentaire.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(40, 50, 70);
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvCommentaire.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvCommentaire.ColumnHeadersHeight = 38;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(220, 230, 245);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvCommentaire.DefaultCellStyle = dataGridViewCellStyle3;
            dgvCommentaire.EnableHeadersVisualStyles = false;
            dgvCommentaire.GridColor = Color.FromArgb(230, 230, 230);
            dgvCommentaire.Location = new Point(25, 12);
            dgvCommentaire.MultiSelect = false;
            dgvCommentaire.Name = "dgvCommentaire";
            dgvCommentaire.ReadOnly = true;
            dgvCommentaire.RowHeadersVisible = false;
            dgvCommentaire.RowHeadersWidth = 51;
            dgvCommentaire.RowTemplate.Height = 32;
            dgvCommentaire.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCommentaire.Size = new Size(753, 416);
            dgvCommentaire.TabIndex = 0;
            // 
            // FormCommentaire
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvCommentaire);
            Name = "FormCommentaire";
            Text = "FormCommentaire";
            Load += FormCommentaire_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCommentaire).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvCommentaire;
    }
}