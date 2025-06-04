using UnityEngine;
using UnityEngine.UI;

public class Gender : MonoBehaviour
{
    public UIManager ui;
    public GenderType genderType;
    public Toggle toggle;

    private void Awake()
    {
        if (toggle == null) toggle = GetComponent<Toggle>();
        toggle.onValueChanged.AddListener(ToggleGender); //подписка на событие
    }

    public void ToggleGender(bool isTrue)
    {
        if (isTrue) ui.SetGender(genderType);
    }
}
