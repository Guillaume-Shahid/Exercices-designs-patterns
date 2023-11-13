using System.Runtime.Serialization;
using System.Text.Json;

namespace Namespace;
public class DictPersistant<T> : IDictPersistant<T>
{

    public bool ajoute(string cle, T objet)
    {
        try
        {
            if (!File.Exists(cle))
            {
                using (FileStream fs = File.Create(cle))
                {
                    JsonSerializer.Serialize(new Utf8JsonWriter(fs), objet);
                }
                return true;
            }
        }
        catch (IOException)
        {
            return false;
        }
        return false;
    }

    public T get(string cle)
    {
        try
        {
            if (File.Exists(cle))
            {
                T resultat;

                try
                {
                    using (FileStream fs = File.OpenRead(cle))
                    {
                        resultat = JsonSerializer.Deserialize<T>(fs)!;
                    }

                }
                catch (SerializationException)
                {
                    throw new KeyNotFoundException();
                }
            }

        }
        catch (IOException)
        {
            throw new KeyNotFoundException();
        }
        throw new KeyNotFoundException();
    }
}
