using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateFinishCounter : MonoBehaviour
{
    public UnityEngine.UI.Text finish;
    void Update()
    {
        finish.text = "Finish : " + CarController.getFinishCounter().ToString();
    }
}
