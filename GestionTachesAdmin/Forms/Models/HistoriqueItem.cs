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
        public string actionRealisee { get; set; } = string.Empty;
        public string Employe { get; set; } = string.Empty;
        public string Tache { get; set; } = string.Empty;
        public DateTime DateAction { get; set; }
    }
}