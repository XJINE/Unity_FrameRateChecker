using UnityEngine;

public class Sample : MonoBehaviour
{
    protected virtual void Update ()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            FrameRateChecker.Instance.Reset();
        }
    }

    protected virtual void OnGUI()
    {
        GUILayout.BeginArea(new Rect(50, 50, 300, 300));
        GUILayout.Label("Press [R] key to reset all.");
        GUILayout.Label("Now : " + FrameRateChecker.Instance.Fps);
        GUILayout.Label("Avg : " + FrameRateChecker.Instance.FpsAvg);
        GUILayout.Label("Min : " + FrameRateChecker.Instance.FpsMin);
        GUILayout.Label("Max : " + FrameRateChecker.Instance.FpsMax);
        GUILayout.EndArea();
    }
}