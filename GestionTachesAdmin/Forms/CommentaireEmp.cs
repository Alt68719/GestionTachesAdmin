using System;
using System;

namespace GestionTachesAdmin.Forms
{
    public class CommentaireModel
    {
        public int IdCommentaire { get; set; }
        public string Contenu { get; set; } = string.Empty;
        public DateTime DateCommentaire { get; set; }
        public string Matricule { get; set; } = string.Empty;
        public int IdTache { get; set; }
    }
}
