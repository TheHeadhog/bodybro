using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
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

    public void ShowWinner(int winner)
    {
        if (winner is 1)
        {
            gameObject.transform.Find("Character1").localScale.Set(1.3f,1.3f,1.3f);
            gameObject.transform.Find("PlayerVictoryLabel").gameObject.GetComponent<TMP_Text>().text = "PLAYER 1";
        }
        else if (winner is 2)
        {
            gameObject.transform.Find("Character2").localScale.Set(1.3f, 1.3f, 1.3f);
            gameObject.transform.Find("PlayerVictoryLabel").gameObject.GetComponent<TMP_Text>().text = "PLAYER 2";
        }
        else
        {
            gameObject.transform.Find("PlayerVictoryLabel").gameObject.GetComponent<TMP_Text>().text = "BALANCED STRENGTH";
        }
    }
}
