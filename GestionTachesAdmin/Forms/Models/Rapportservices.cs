using System;
using System.Runtime.InteropServices.Marshalling;

public class ProductiviteService
{ 
    public RapportProductivite GenererRapport(int employeId, List<Tache> toutesLesTaches, DateTime debut, DateTime fin)
    {
        var tachesEmploye = toutesLesTaches
            .Where(t => t.EmployeId == employeId && t.DateCreation >= debut && t.DateCreation <= fin)
            .ToList();

        int terminees = tachesEmploye.Count(t => t.Statut == StatutTache.Terminee);
        int enRetard = tachesEmploye.Count(t => t.Statut != StatutTache.Terminee && t.DateEcheance < DateTime.Now);

        return new RapportProductivite
        {
            EmployeId = employeId,
            DateDebutPeriode = debut,
            DateFinPeriode = fin,
            TachesAssignees = tachesEmploye.Count,
            TachesTerminees = terminees,
            TachesEnRetard = enRetard
        };
    }
}
