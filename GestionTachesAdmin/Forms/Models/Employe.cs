namespace GestionTachesAdmin.Models
{
    public class Employe
    {
        public string Matricule { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Poste { get; set; }
        public string MotDePasse { get; set; } // Nouvel attribut ajouté
        public string NomComplet => $"{Nom} {Prenom} ({Matricule})";
    }
}