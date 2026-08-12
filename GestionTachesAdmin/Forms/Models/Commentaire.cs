using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionTachesAdmin.Forms.Models
{
    public class Commentaire
    {
        public int IdCommentaire {  get; set; }
        public string Contenu { get; set; } = string.Empty;
        public DateTime dateComment {  get; set; }
        public string matriculeEmp { get; set; } = string.Empty;
        public int idTache { get; set; }
    }
}
