using UnityEngine;
using System.Collections;

public class TimeScale : MonoBehaviour {

    private float timeScale;

    void OnGUI()
    {
        GUI.Label(new Rect(10, 20, 30, 20), new GUIContent("Time Scale"));
        timeScale = GUI.HorizontalSlider(new Rect(10, 40, 150, 40), timeScale, -4, 4);
        Time.timeScale = Mathf.Exp(timeScale);
    }
}
