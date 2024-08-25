using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateGameSpeed : MonoBehaviour
{
    public UnityEngine.UI.Slider slider;

    void Update()
    {
        Time.timeScale = slider.value;
    }
}

