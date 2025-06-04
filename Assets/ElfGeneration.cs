using UnityEngine;
using System.Linq;

public class ElfGeneration : MonoBehaviour
{
    // Префиксы (начало имени)
    private static readonly string[] Prefixes = { "Ae", "El", "Thal", "Fae", "Kael", "Lor", "Syl", "Ther", "Vae", "Cal", "Ari", "Ly", "Se", "Ny", "Il", "My", "Ya", "Ri", "Sa", "Al", "Na", "Is", "Or", "Za" };

    // Средние части (для удлинения имени)
    private static readonly string[] Middles = { "ran", "lor", "dil", "lar", "thas", "ion", "var", "ron", "lis", "nor", "an", "el", "une", "ria", "mir", "nya", "tha", "van", "iel", "eth", "wen", "las" };

    // Суффиксы (окончания, разделены по гендеру)
    private static readonly string[] MaleSuffixes = { "or", "il", "as", "ion", "ar", "an", "is" };
    private static readonly string[] FemaleSuffixes = { "elle", "ia", "ra", "ya", "wen", "iel", "une" };
    private static readonly string[] NeutralSuffixes = { "eth", "is", "ar", "el" };

    public static string GenerateElfName(string gender = "neutral")
    {
        string prefix = Prefixes[Random.Range(0, Prefixes.Length)];
        string middle = Random.Range(0, 2) == 0 ? Middles[Random.Range(0, Middles.Length)] : "";
        string suffix;

        // Выбор суффикса в зависимости от гендера
        switch (gender.ToLower())
        {
            case "male":
                suffix = MaleSuffixes[Random.Range(0, MaleSuffixes.Length)];
                break;
            case "female":
                suffix = FemaleSuffixes[Random.Range(0, FemaleSuffixes.Length)];
                break;
            default:
                suffix = NeutralSuffixes[Random.Range(0, NeutralSuffixes.Length)];
                break;
        }

        string name = prefix + middle + suffix;
        return char.ToUpper(name[0]) + name.Substring(1);
    }

    // Метод для генерации нескольких имен
    public static string[] GenerateMultipleElfNames(int count, string gender = "neutral")
    {
        return Enumerable.Range(0, count)
            .Select(_ => GenerateElfName(gender))
            .ToArray();
    }
}