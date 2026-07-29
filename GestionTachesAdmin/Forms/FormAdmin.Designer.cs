namespace GestionTachesAdmin
{
    partial class FormAdmin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            cmbEmployes = new ComboBox();
            cmbTaches = new ComboBox();
            btnAttribuer = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(180, 20);
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
            label3.Location = new Point(0, 157);
            label3.Name = "label3";
            label3.Size = new Size(166, 20);
            label3.TabIndex = 2;
            label3.Text = "Sélectionner une tâche :";
            // 
            // cmbEmployes
            // 
            cmbEmployes.FormattingEnabled = true;
            cmbEmployes.Location = new Point(0, 46);
            cmbEmployes.Name = "cmbEmployes";
            cmbEmployes.Size = new Size(246, 28);
            cmbEmployes.TabIndex = 3;
            // 
            // cmbTaches
            // 
            cmbTaches.FormattingEnabled = true;
            cmbTaches.Location = new Point(0, 213);
            cmbTaches.Name = "cmbTaches";
            cmbTaches.Size = new Size(246, 28);
            cmbTaches.TabIndex = 4;
            // 
            // btnAttribuer
            // 
            btnAttribuer.BackColor = SystemColors.HotTrack;
            btnAttribuer.Font = new Font("Cooper Black", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAttribuer.ForeColor = SystemColors.Desktop;
            btnAttribuer.Location = new Point(299, 382);
            btnAttribuer.Name = "btnAttribuer";
            btnAttribuer.Size = new Size(187, 41);
            btnAttribuer.TabIndex = 5;
            btnAttribuer.Text = "Attribuer";
            btnAttribuer.UseVisualStyleBackColor = false;
            btnAttribuer.Click += btnAttribuer_Click;
            // 
            // FormAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAttribuer);
            Controls.Add(cmbTaches);
            Controls.Add(cmbEmployes);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormAdmin";
            Text = "Form1";
            Load += FormAdmin_Load;
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
    }
}
