using UnityEngine;

[RequireComponent(typeof(Camera))]
public class FpsControlEffect : MonoBehaviour
{
    #region Field

    public Material material;

    public Vector2Int resolution = new Vector2Int(1280, 720);

    public float fps = 30;

    protected float ellapsedTime;

    protected RenderTexture currentFrame;

    #endregion Field

    #region Method

    protected virtual void Awake()
    {
        this.currentFrame = new RenderTexture(this.resolution.x, this.resolution.y, 0, RenderTextureFormat.ARGB32);
    }

    protected virtual void OnDestroy()
    {
        GameObject.DestroyImmediate(this.currentFrame);
    }

    protected virtual void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        float timePerFrame = 1f / this.fps;
        this.ellapsedTime += Time.deltaTime;

        if (timePerFrame <= this.ellapsedTime)
        {
            Graphics.Blit(source, this.currentFrame, this.material);
            this.ellapsedTime -= timePerFrame;
        }

        Graphics.Blit(this.currentFrame, destination, this.material);
    }

    #endregion Method
}