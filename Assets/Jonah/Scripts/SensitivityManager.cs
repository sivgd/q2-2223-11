using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SensitivityManager : MonoBehaviour
{
    [SerializeField] Slider SensitivitySlider;

    // Start is called before the first frame update
    void Start()
    {
        if (!PlayerPrefs.HasKey("Sensitivity"))
        {
            PlayerPrefs.SetFloat("Sensitivity", 1);
            Load();
        }
        else
        {
            Load();
        }
    }

    public void ChangeSensitivity()
    {
        GameManager.Sensitivity = SensitivitySlider.value;
        Save();
    }

    private void Load()
    {
        SensitivitySlider.value = PlayerPrefs.GetFloat("Sensitivity");
    }

    private void Save()
    {
        PlayerPrefs.SetFloat("Sensitivity", SensitivitySlider.value);
    }
}
