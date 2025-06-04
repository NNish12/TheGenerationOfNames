using UnityEngine;

public class OrcGeneration : MonoBehaviour
{
    public UIManager ui;
    private static readonly string[] prefixEn ={ "Gor", "Ur", "Krag", "Brak", "Zul", "Thok", "Drak", "Kaz", "Mog", "Ruk",
        "Gruk", "Bol", "Nar", "Vok", "Thrag", "Krog", "Uzg", "Drok", "Snar", "Hruk"};
    private static readonly string[] middleEn = { "gash", "dur", "mak", "thul", "nug", "brok", "zug", "rak", "mog", "tur",
        "gul", "rag", "lok", "zug", "grah", "vor", "dum", "ruk", "gar", "trak"};
    private static readonly string[] suffixMaleEn = { "thar", "gorn", "mok", "ruk", "drak", "zan", "tok", "gar", "grush", "nak",
        "varg", "grim", "zul", "torg", "brak", "zug", "nash", "lok", "dush", "kran"};
    private static readonly string[] suffixFemaleEn ={ "gra", "nasha", "mora", "zura", "basha", "daga", "mara", "luga", "shura", "kala",
        "drasha", "gura", "zila", "nura", "vasha", "thora", "shaga", "rala", "hura", "baka"};
    private static readonly string[] prefixRus ={ "Грак", "Ург", "Морг", "Крог", "Брог", "Зул", "Трак", "Шуг", "Дрог", "Каз",
    "Ворг", "Храг", "Брум", "Заг", "Туг", "Рак", "Фраг", "Гах", "Жул", "Шарг" };
    private static readonly string[] middleRus = { "гар", "тур", "брак", "мак", "нок", "дар", "раг", "зур", "ман", "вуг",
        "шак", "гул", "лук", "шур", "крог", "нур", "мург", "грак", "фар", "драк" };
    private static readonly string[] suffixMaleRus ={ "тар", "маг", "лок", "граш", "рог", "нак", "ург", "шах", "душ", "бак",
        "гар", "бул", "грак", "маз", "шуг", "зуг", "дан", "груш", "вак", "шак" };
    private static readonly string[] suffixFemaleRus = { "гаша", "рула", "дуга", "мага", "шара", "тула", "шира", "маша", "нага",
        "бруна", "зара", "лугра", "рагша", "друна", "шила", "грула", "каша", "жара", "нура"};

    public string OrcGenerateName()
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
