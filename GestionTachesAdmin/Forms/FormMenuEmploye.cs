using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionTachesAdmin.Forms
{
    public partial class FormMenuEmploye : Form
    {
        private string matricule;
        public FormMenuEmploye(string matricule)
        {
            InitializeComponent();
            this.matricule = matricule;
        }
        private void FormAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
