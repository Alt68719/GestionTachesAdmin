namespace GestionTachesAdmin.Forms.Models
{
    public class Employe
    {
        public string Matricule { get; set; } = string.Empty;
        public string Nom { get; set; } = string.Empty;
        public string Prenom { get; set; } = string.Empty;
        public string Poste { get; set; } = string.Empty;
        public string MotDePasse { get; set; } = string.Empty;
        public string NomComplet => $"{Nom} {Prenom} ({Matricule})";
    }
}