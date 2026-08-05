using System;

public class CommentaireService
{
    private readonly List<Commentaire> _commentaires = new();

    public void AjouterCommentaire(int tacheId, int auteurId, string texte)
    {
        if (string.IsNullOrWhiteSpace(texte))
            throw new ArgumentException("Le commentaire ne peut pas être vide.");

        var nouveauCommentaire = new Commentaire
        {
            Id = _commentaires.Count + 1,
            TacheId = tacheId,
            AuteurId = auteurId,
            Contenu = texte,
            DatePublication = DateTime.Now
        };

        _commentaires.Add(nouveauCommentaire);
    }

    public List<Commentaire> ObtenirCommentairesParTache(int tacheId)
    {
        return _commentaires
            .Where(c => c.TacheId == tacheId)
            .OrderByDescending(c => c.DatePublication)
            .ToList();
    }
}
