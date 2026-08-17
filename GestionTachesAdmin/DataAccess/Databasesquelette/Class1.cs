namespace GestionTachesAdmin.Forms.Models
{
    public class RapportProductivite
    {
        public string Matricule { get; set; } = string.Empty;
        public string EmployeNom { get; set; } = string.Empty;
        public int TachesAssignees { get; set; }
        public int TachesTerminees { get; set; }
        public int TachesEnCours => TachesAssignees - TachesTerminees;
        public double HeuresTravaillees { get; set; }

        public double TauxCompletion => TachesAssignees > 0
            ? Math.Round(((double)TachesTerminees / TachesAssignees) * 100, 2)
            : 0;
    }
}