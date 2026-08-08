using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionTachesAdmin.DataAccess;
using GestionTachesAdmin.Forms.Models;

namespace GestionTachesAdmin.Forms
{
    public partial class FormCommentaire : Form
    {
        public FormCommentaire()
        {
            InitializeComponent();
        }

        private void FormCommentaire_Load(object sender, EventArgs e)
        {
            List<Commentaire> commentaire = CommentaireDAO.GetCommentaire();
            dgvCommentaire.DataSource = null;
            dgvCommentaire.DataSource = commentaire;

            if (dgvCommentaire.Columns["IdCommentaire"] != null)
            {
                dgvCommentaire.Columns["IdCommentaire"].HeaderText = "ID";
            }
            if (dgvCommentaire.Columns["Contenu"] != null)
            {
                dgvCommentaire.Columns["Contenu"].HeaderText = "Contenu";
            }
            if (dgvCommentaire.Columns["dateCommment"] != null)
            {
                dgvCommentaire.Columns["dateComment"].HeaderText = "Date & Heure";
            }
            if (dgvCommentaire.Columns["matriculeEmp"] != null)
            {
                dgvCommentaire.Columns["matriculeEmp"].HeaderText = "Employé concerné";
            }
            if (dgvCommentaire.Columns["iTtache"] != null)
            {
                dgvCommentaire.Columns["idTache"].HeaderText = "Tâche";
            }
        }
    }
}
