using UnityEngine;

public class ProgressBar : MonoBehaviour
{
    [SerializeField] private Transform foregroundTransform;

    public void SetProgress(float progress)
    {
        float x = foregroundTransform.localScale.x;
        float y = progress;
        float z = foregroundTransform.localScale.z;
        foregroundTransform.localScale = new Vector3(x, y, z);
    }
}
