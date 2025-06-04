using TMPro;
using UnityEngine;

public class GenerateButton : MonoBehaviour
{
    public UIManager ui;
    public TextMeshProUGUI generatedNameField;
    public ElfGeneration elfGeneration; //изменить потом
    private string generatedName = "Mudro"; //инициализация по умолчанию
    public string GeneratedName
    {
        get { return generatedName; }
        set { generatedName = value; }
    }
    public void SetGeneratedName()
    {
        // switch (race)
        // {
        //     case RaceType.Elf:
        generatedNameField.text = elfGeneration.ElfGenerateName(ui.language, ui.gender);
        // return "";
        // case RaceType.Orc:
        // case RaceType.Dwarf:
        // }
    }
    //создать метод, который принимает пол из ui менеджера
    //и генерирует имя в зависимости от выбранной расы - выбор из трех методов,
    //каждый из которых принимает пол
    //
    // generatedNameField.text = elfGeneration.ElfGenerateName(ui.genderType, ui.languageType);
    // if (ui.languageType) elf.
}
public enum NamePartType { Prefix, Middle, Suffix }
