using TMPro;
using UnityEngine;

public class GenerateButton : MonoBehaviour
{
    public UIManager ui;
    public TextMeshProUGUI generatedNameField;
    public ElfGeneration elfGeneration;
    public OrcGeneration orcGeneration;
    public DwarfGeneration dwarfGeneration;
    private string generatedName = "Mudro"; //инициализация по умолчанию
    public string GeneratedName
    {
        get { return generatedName; }
        set { generatedName = value; }
    }
    public void SetGeneratedName()
    {
        switch (ui.race)
        {
            case RaceType.Elf:
                generatedNameField.text = elfGeneration.ElfGenerateName();
                break;
            case RaceType.Orc:
                generatedNameField.text = orcGeneration.OrcGenerateName();
                break;
            case RaceType.Dwarf:
                generatedNameField.text = dwarfGeneration.DwarfGenerateName();
                break;
        }

    }
}
public enum NamePartType { Prefix, Middle, Suffix }
