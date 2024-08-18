using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VictoryMenuManager : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> ObjectsToHide;
    [SerializeField]
    private List<GameObject> ObjectsToShow;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("GameLevelScene");
        }
    }

    private void OnEnable()
    {
        foreach (var toHide in ObjectsToHide)
        {
            toHide.SetActive(false);
        }

        foreach (var toShow in ObjectsToShow)
        {
            toShow.SetActive(true);
        }
    }
}
