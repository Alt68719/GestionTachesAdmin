using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionTachesAdmin
{
    public partial class FormMenuPrincipal : Form
    {
        public FormMenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnOuvrirAttribution_Click(object sender, EventArgs e)
        {
            FormAdmin FormAttribution = new FormAdmin();
            FormAttribution.Show();
        }

        private void btnOuvrirCreation_Click(object sender, EventArgs e)
        {
            FormCreationTache FormCreation = new FormCreationTache();
            FormCreation.Show();
        }

        private void btnOuvrirCreationEmploye_Click(object sender, EventArgs e)
        {
            FormCreationEmploye FormCreationEmploye = new FormCreationEmploye();
            FormCreationEmploye.Show();
        }
        private void btnOuvrirAvancement_Click(object sender, EventArgs e)
        {
            FormAvancement FormAvancement = new FormAvancement();
            FormAvancement.Show();
        }
    }
}
