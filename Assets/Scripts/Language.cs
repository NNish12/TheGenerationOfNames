using UnityEngine;
using UnityEngine.UI;

public class Language : MonoBehaviour
{
    public UIManager ui;
    public LanguageType languageType;
    public Toggle toggle;

    public void Awake()
    {
        if (toggle == null)
            toggle = GetComponent<Toggle>();
        toggle.onValueChanged.AddListener(ToggleLanguage);
    }
    public void ToggleLanguage(bool isTrue)
    {
        if (isTrue)
            ui.SetLanguage(languageType);

    }
}
