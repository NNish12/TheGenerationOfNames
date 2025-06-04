using Unity.VisualScripting;
using UnityEngine;

public class ElfGeneration : MonoBehaviour
{
    public UIManager ui;
    private readonly string[] prefixEn = { "Ae", "El", "Thal", "Fae", "Kael", "Lor",
        "Syl", "Ther", "Vae", "Cal", "Ari", "Ly", "Se", "Ny", "Il", "My", "Ya",
        "Ri", "Sa", "Al", "Na", "Is", "Or", "Za" };
    private readonly string[] middleEn = { "ran", "lor", "dil", "lar", "thas",
        "ion", "var", "ron", "lis", "nor", "an", "el", "une", "ria", "mir", "nya",
        "tha", "van", "iel", "eth", "wen", "las" };
    private readonly string[] suffixMaleEn = { "or", "il", "as", "ion", "ar", "an", "is" };
    private readonly string[] suffixFemaleEn = { "a", "ia", "elle", "ina", "ara", "ina", "essa" };
    private readonly string[] prefixRus = {
        "А", "Эль", "Сол", "Вар", "Лун", "Зар", "Мир", "Свят", "Яр", "Бор",
        "Вел", "Дар", "Стан", "Рад", "Гор", "Тим", "Иль", "Кир", "Сев", "Ол",
        "Нар", "Тар", "Жар", "Вик", "Лев" };
    private readonly string[] middleRus = {
        "ис", "ар", "ел", "ан", "ир", "ов", "ун", "ес", "ор", "ин",
        "ав", "ил", "яр", "ен", "уш", "оль", "ик", "ем", "оз", "ал",
        "ур", "иан" };
    private readonly string[] suffixMaleRus = { "ий", "ор", "ан", "ис", "ель", "он", "ар" };
    private readonly string[] suffixFemaleRus = { "а", "ия", "ина", "ера", "ита", "ель", "ица" };
    public string ElfGenerateName(LanguageType language, GenderType gender)
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

                // или можно через if else проверить гендер
        }
        return null;
    }

    // private string GetSuffixGender(GenderType genderType)
    // {
    //     string[] array;
    //     if (genderType == GenderType.Male) array = suffixMaleEn;
    //     else array = suffixFemaleEn;

    //     int index = Random.Range(0, array.Length);
    //     return array[index];
    // }
}
