namespace GestionTachesAdmin.Forms
{
    partial class FormNotification
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
            dataGridViewNotif = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewNotif).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewNotif
            // 
            dataGridViewNotif.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewNotif.Location = new Point(12, 53);
            dataGridViewNotif.Name = "dataGridViewNotif";
            dataGridViewNotif.RowHeadersWidth = 51;
            dataGridViewNotif.Size = new Size(1017, 547);
            dataGridViewNotif.TabIndex = 0;
            // 
            // FormNotification
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1041, 612);
            Controls.Add(dataGridViewNotif);
            Name = "FormNotification";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridViewNotif).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewNotif;
    }
}