using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionTachesAdmin.Forms.Models
{
    public class HistoriqueItem
    {
        public int IdHistorique { get; set; }
        public string actionRealisee { get; set; }
        public DateTime DateAction { get; set; }
        public string Employe { get; set; }
        public string Tache { get; set; }
    }
}
