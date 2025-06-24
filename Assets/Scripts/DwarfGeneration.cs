using UnityEngine;

public class DwarfGeneration : MonoBehaviour
{
    public UIManager ui;
    private static string[] prefixEn = { "Dur", "Balin", "Thro", "Gim", "Khar", "Mor", "Bram", "Dro", "Har", "Tor" };
    private static string[] middleEn = { "in", "ar", "or", "im", "un", "ak", "ul", "ad", "en", "ok" };
    private static string[] suffixMaleEn = { "in", "ar", "or", "im", "un", "ak", "ad" };
    private static string[] suffixFemaleEn = { "a", "ia", "ara", "ina", "ela", "ara", "ina" };

    private static string[] prefixRus = { "Дур", "Бал", "Тро", "Гим", "Кар", "Мор", "Брам", "Дро", "Хар", "Тор" };
    private static string[] middleRus = { "ин", "ар", "ор", "им", "ун", "ак", "ул", "ад", "ен", "ок" };
    private static string[] suffixMaleRus = { "ий", "ар", "ор", "им", "ун", "ак", "ад" };
    private static string[] suffixFemaleRus = { "а", "ия", "ара", "ина", "ела", "ара", "ина" };

    public string DwarfGenerateName()
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
