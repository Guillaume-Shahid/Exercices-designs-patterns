namespace Namespace;
public class DictProxy<T> : DictPersistant<T>
{
    protected DictPersistant<T> dictPersistant = new();
    protected IDictionary<string, T> contenu = new Dictionary<string, T>();


    public bool ajoute(string cle, T objet)
    {
        bool resultat = dictPersistant.ajoute(cle, objet);
        if (resultat)
        {
            contenu.Add(cle, objet);
        }
        return resultat;
    }

    public T get(string cle)
    {
        if (contenu.ContainsKey(cle))
        {
            return contenu[cle];
        }
        else
        {
            T resultat = dictPersistant.get(cle);
            contenu.Add(cle, resultat);
            return resultat;
        }
    }
}

