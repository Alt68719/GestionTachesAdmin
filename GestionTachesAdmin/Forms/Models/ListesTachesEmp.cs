using System;

namespace GestionTachesAdmin.Forms.Models
{
    public class ListesTachesEmp
    {
        public int Idtache { get; set; }
        public string titre { get; set; } = string.Empty;
        public string description { get; set; } = string.Empty;
        public string priorite { get; set; } = string.Empty;
        public string status { get; set; } = string.Empty;
        public DateTime date_limite { get; set; }
    }
}