using UnityEngine;

public class FpsControlEffectSample : MonoBehaviour
{
    #region Field

    public FpsControlEffect fpsControlEffect;

    #endregion Field

    void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            this.fpsControlEffect.fps = 5f;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            this.fpsControlEffect.fps = 10f;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            this.fpsControlEffect.fps = 20f;
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            this.fpsControlEffect.fps = 30f;
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            this.fpsControlEffect.fps = 60f;
        }
    }

    private void OnGUI()
    {
        GUILayout.Label("FPS : " + this.fpsControlEffect.fps);
        GUILayout.Label("PRESS 1 KEY : FPS 05");
        GUILayout.Label("PRESS 2 KEY : FPS 10");
        GUILayout.Label("PRESS 3 KEY : FPS 20");
        GUILayout.Label("PRESS 4 KEY : FPS 30");
        GUILayout.Label("PRESS 5 KEY : FPS 60");
    }
}