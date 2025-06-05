using UnityEngine;

public class NameGenerator : MonoBehaviour
{
    public UIManager ui;
    protected static string[] prefixEn;
    protected static string[] middleEn;
    protected static string[] suffixMaleEn;
    protected static string[] suffixFemaleEn;
    protected static string[] prefixRus;
    protected static string[] middleRus;
    protected static string[] suffixMaleRus;
    protected static string[] suffixFemaleRus;

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
