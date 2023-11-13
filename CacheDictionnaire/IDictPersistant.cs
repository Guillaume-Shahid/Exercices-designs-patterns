namespace Namespace;
public interface IDictPersistant<T>
{
    bool ajoute(string cle, T objet);
    T get(string cle);
}
