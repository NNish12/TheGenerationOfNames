using TMPro;
using UnityEngine;

public class GenerateButton : MonoBehaviour
{
    public UIManager ui;
    public TextMeshProUGUI generatedNameField;
    private string generatedName = "Default Name"; //инициализация по умолчанию
    public string GeneratedName
    {
        get { return generatedName; }
        set { generatedName = value; }
    }
    public void SetGeneratedName(string GeneratedName)
    {
        generatedNameField.text = GeneratedName;
    }
}
