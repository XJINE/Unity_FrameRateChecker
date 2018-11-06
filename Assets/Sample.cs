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
        GUILayout.Label("FPS : " + FrameRateChecker.Instance.Fps);
        GUILayout.Label("AVG : " + FrameRateChecker.Instance.FpsAvg);
        GUILayout.Label("MIN : " + FrameRateChecker.Instance.FpsMin);
        GUILayout.Label("MAX : " + FrameRateChecker.Instance.FpsMax);
        GUILayout.EndArea();
    }
}