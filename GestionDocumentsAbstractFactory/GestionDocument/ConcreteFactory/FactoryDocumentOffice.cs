namespace Namespace;
public class FactoryDocumentOffice : IFactoryDocument
{
    public IDocumentFeuilleDeCalcul creerDocumentFeuilleDeCalcul()
    {
        return new DocumentFeuilleDeCalcul();
    }

    public IDocumentPresentation creerDocumentPresentation()
    {
        return new DocumentPresentation();
    }

    public IDocumentTexte creerDocumentTexte()
    {
        return new DocumentTexte();
    }
}
