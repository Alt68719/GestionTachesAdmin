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
            dgvCommentaire = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvCommentaire).BeginInit();
            SuspendLayout();
            // 
            // dgvCommentaire
            // 
            dgvCommentaire.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCommentaire.Location = new Point(31, 4);
            dgvCommentaire.Name = "dgvCommentaire";
            dgvCommentaire.RowHeadersWidth = 51;
            dgvCommentaire.Size = new Size(726, 434);
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