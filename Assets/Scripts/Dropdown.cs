using UnityEngine;

public class Dropdown : MonoBehaviour
{
    public UIManager ui;

    public void DropdownList(int index)
    {
        switch (index)
        {
            case 0:
                ui.SetRace(RaceType.Elf);
                break;
            case 1:
                ui.SetRace(RaceType.Orc);
                break;
            case 2:
                ui.SetRace(RaceType.Dwarf);
                break;
        }
    }
}
