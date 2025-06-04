using UnityEngine;
using UnityEngine.UI;

public class Race : MonoBehaviour
{
    public UIManager ui;
    public RaceType raceType;
    public Toggle toggle;
    private void Awake()
    {
        if (toggle == null) toggle = GetComponent<Toggle>();
        toggle.onValueChanged.AddListener(ToggleRace);
    }

    public void ToggleRace(bool isTrue)
    {
        if (isTrue) ui.SetRace(raceType);
     }
}
