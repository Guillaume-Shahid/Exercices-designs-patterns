namespace Namespace;
public interface IFactoryDocument
{
    IDocumentTexte creerDocumentTexte();
    IDocumentFeuilleDeCalcul creerDocumentFeuilleDeCalcul();
    IDocumentPresentation creerDocumentPresentation();
}
