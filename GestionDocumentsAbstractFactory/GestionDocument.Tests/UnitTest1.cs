using Namespace;

namespace GestionDocument.Tests;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void FactoryDocumentOfficeCreerdocumentShouldBeInstanceOfIdocument()
    {
        // Arrange
        var officeFactory = new FactoryDocumentOffice();
        // Act
        var document = officeFactory.creerDocumentTexte();
        // Assert
        Assert.IsInstanceOfType(document, typeof(IDocumentTexte));
    }

    [TestMethod]
    public void FactoryDocumentOfficeCreerDocumentFeuilleDeCalculShouldBeInstanceOfIDocumentFeuilleDeCalcul()
    {
        // Arrange
        var officeFactory = new FactoryDocumentOffice();
        // Act
        var document = officeFactory.creerDocumentFeuilleDeCalcul();
        // Assert
        Assert.IsInstanceOfType(document, typeof(IDocumentFeuilleDeCalcul));
    }

    [TestMethod]
    public void FactoryDocumentOfficeCreerDocumentPresentationShouldBeInstanceOfIDocumentPresentation()
    {
        // Arrange
        var officeFactory = new FactoryDocumentOffice();
        // Act
        var document = officeFactory.creerDocumentPresentation();
        // Assert
        Assert.IsInstanceOfType(document, typeof(IDocumentPresentation));
    }

    [TestMethod]
    public void FactoryDocumentGoogleCreerdocumentShouldBeInstanceOfIdocument()
    {
        // Arrange
          var googleFactory = new FactoryDocumentGoogle();
        // Act
        var document =  googleFactory.creerDocumentTexte();
        // Assert
        Assert.IsInstanceOfType(document, typeof(IDocumentTexte));
    }

        [TestMethod]
    public void FactoryDocumentGoogleCreerDocumentFeuilleDeCalculShouldBeInstanceOfIDocumentFeuilleDeCalcul()
    {
        // Arrange
          var googleFactory = new FactoryDocumentGoogle();
        // Act
        var document =  googleFactory.creerDocumentFeuilleDeCalcul();
        // Assert
        Assert.IsInstanceOfType(document, typeof(IDocumentFeuilleDeCalcul));
    }

        [TestMethod]
    public void FactoryDocumentGoogleCreerDocumentPresentationShouldBeInstanceOfIDocumentPresentation()
    {
        // Arrange
          var googleFactory = new FactoryDocumentGoogle();
        // Act
        var document =  googleFactory.creerDocumentPresentation();
        // Assert
        Assert.IsInstanceOfType(document, typeof(IDocumentPresentation));
    }
}