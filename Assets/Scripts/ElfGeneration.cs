using Unity.VisualScripting;
using UnityEngine;

public class ElfGeneration : MonoBehaviour
{
    public UIManager ui;
    private static readonly string[] prefixEn = { "Ae", "El", "Thal", "Fae", "Kael", "Lor",
        "Syl", "Ther", "Vae", "Cal", "Ari", "Ly", "Se", "Ny", "Il", "My", "Ya",
        "Ri", "Sa", "Al", "Na", "Is", "Or", "Za" };
    private static readonly string[] middleEn = { "ran", "lor", "dil", "lar", "thas",
        "ion", "var", "ron", "lis", "nor", "an", "el", "une", "ria", "mir", "nya",
        "tha", "van", "iel", "eth", "wen", "las" };
    private static readonly string[] suffixMaleEn = { "or", "il", "as", "ion", "ar", "an", "is" };
    private static readonly string[] suffixFemaleEn = { "a", "ia", "elle", "ina", "ara", "ina", "essa" };
    private static readonly string[] prefixRus = { "Эль", "Ли", "Сай", "Фаэ", "Ири", "Ти", "Наэ", "Али",
        "Вэл", "Шаэ","Каэ", "Эн", "Ри", "Ла", "Таэ", "Гэл", "Ни", "Эри", "Юл", "Си" };

    private static readonly string[] middleRus = {
        "эль", "ан", "ор", "иан", "ар", "ион", "ен", "рад", "иль", "вэн",
        "тан", "дор", "лан", "азар", "ир", "сар", "тай", "рен", "галь", "фар"};
    private static readonly string[] suffixMaleRus = { "ий", "ор", "ан", "ис", "ель", "он", "ар" };
    private static readonly string[] suffixFemaleRus = { "эль", "ия", "ира", "ана", "ариэль", "еста", "елла",
        "элина", "исса", "иэль", "мира", "саэ", "вэль", "шия", "алия", "эльва", "нэя", "ираэль", "илин", "элария"};
    public string ElfGenerateName()
    {
        int isMiddle = Random.Range(0, 2); // 0 - нет середины, 1 - есть середина
        string currentPrefix = GetRandomString(GetNameParts(NamePartType.Prefix, ui.language, ui.gender));
        string currentMiddle = isMiddle == 1 ? GetRandomString(GetNameParts(NamePartType.Middle, ui.language, ui.gender)) : "";
        string currentSuffix = GetRandomString(GetNameParts(NamePartType.Suffix, ui.language, ui.gender));
        string name = currentPrefix + currentMiddle + currentSuffix;

        return name;
    }
    private string GetRandomString(string[] array)
    {
        int index = Random.Range(0, array.Length);
        return array[index];
    }
    private string[] GetNameParts(NamePartType part, LanguageType language, GenderType gender)
    {
        switch (part)
        {
            case NamePartType.Prefix:
                return language == LanguageType.En ? prefixEn : prefixRus;
                ;
            case NamePartType.Middle:
                return language == LanguageType.En ? middleEn : middleRus;
            case NamePartType.Suffix:
                if (language == LanguageType.En) return gender == GenderType.Male ? suffixMaleEn : suffixFemaleEn;
                else if (gender == GenderType.Male) return suffixMaleRus;
                else return suffixFemaleRus;
        }
        return null;
    }
}
