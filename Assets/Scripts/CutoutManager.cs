using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutoutManager : MonoBehaviour
{
    private PlayerBody cutoutBody;
    // Start is called before the first frame update
    void Start()
    {
        SetupCutoutBody();
    }

    private void SetupCutoutBody()
    {
        cutoutBody = GetComponentInChildren<PlayerBody>();
        cutoutBody.RandomizeCutoutStats();
    }
}
