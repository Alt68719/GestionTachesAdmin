using System;

namespace GestionTachesAdmin.Forms.Models
{
    public class ListesTachesEmp
    {
        public int Id_tache { get; set; }
        public string Titre_Tache { get; set; } = string.Empty;
        public string Priorite_Tache { get; set; } = string.Empty;
        public DateTime Date_Lime_Tache { get; set; }
        public bool Statut_Tache { get; set; }
    }
}