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

    [SerializeField]
    private TMP_Text ResultLabel;
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

    public void ShowWinner(int winner,int p1Points,int p2Points)
    {
        if (winner is 1)
        {
            GameObject.FindGameObjectWithTag("PlayerVictoryLabel").GetComponent<TMP_Text>().text = "PLAYER 1";
        }
        else if (winner is 2)
        {
            GameObject.FindGameObjectWithTag("PlayerVictoryLabel").GetComponent<TMP_Text>().text = "PLAYER 2";
        }
        else
        {
            GameObject.FindGameObjectWithTag("PlayerVictoryLabel").GetComponent<TMP_Text>().text = "BALANCED STRENGTH";
        }

        ResultLabel.text = $"{p2Points}:{p1Points}";
    }
}
