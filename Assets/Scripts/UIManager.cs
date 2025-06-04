using UnityEngine;

public class UIManager : MonoBehaviour
{
    [Header("Starting parameters")]
    public GenderType genderType = GenderType.Male;
    public RaceType raceType = RaceType.Elf;
    public void SetGender(GenderType genderType)
    {
        this.genderType = genderType;
        Debug.Log(genderType);
    }
    public void SetRace(RaceType raceType)
    {
        this.raceType = raceType;
        Debug.Log(raceType);
    }
}
public enum GenderType { Male, Female }
public enum RaceType { Elf, Orc, Dwarf }
