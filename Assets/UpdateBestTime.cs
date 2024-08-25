using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateBestTime : MonoBehaviour
{
    public UnityEngine.UI.Text Time;

    void Update()
    {
        Time.text = "Best Time: " + CarController.getBestTimeCounter().ToString();
    }
}
