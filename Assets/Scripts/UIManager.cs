using UnityEngine;

public class UIManager : MonoBehaviour
{
    [Header("Starting parameters")]
    public GenderType gender = GenderType.Male;
    public RaceType race = RaceType.Elf;
    public LanguageType language = LanguageType.Rus;
    public void SetGender(GenderType gender)
    {
        this.gender = gender;
        Debug.Log(gender);
    }
    public void SetRace(RaceType raceType)
    {
        this.race = raceType;
        Debug.Log(raceType);
    }
    public void SetLanguage(LanguageType languageType)
    { 
        this.language = languageType;
        Debug.Log(languageType);
    }
}
public enum GenderType { Male, Female }
public enum RaceType { Elf, Orc, Dwarf }
public enum LanguageType { Rus, En }
