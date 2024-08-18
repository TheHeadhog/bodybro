
using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private PlayerBody playerOneBody;
    private PlayerBody playerOneCutout; 
    private PlayerBody playerTwoBody;
    private PlayerBody playerTwoCutout;

    [SerializeField]
    private GameObject victoryMenu;
    // Start is called before the first frame update
    void Start()
    {
        playerOneBody =GameObject.FindGameObjectWithTag("PlayerOneBody").GetComponent<PlayerBody>();
        playerOneCutout =GameObject.FindGameObjectWithTag("PlayerOneCutout").GetComponent<PlayerBody>(); 
        playerTwoBody =GameObject.FindGameObjectWithTag("PlayerTwoBody").GetComponent<PlayerBody>();
        playerTwoCutout =GameObject.FindGameObjectWithTag("PlayerTwoCutout").GetComponent<PlayerBody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DecideWinner()
    {
        var playerOneDiff = playerOneBody.CalculateDifference(playerOneCutout);
        var playerTwoDiff = playerTwoBody.CalculateDifference(playerTwoCutout);

        var winner = playerTwoDiff > playerOneDiff ? 1 : 2;
        victoryMenu.SetActive(true);
        victoryMenu.GetComponent<VictoryMenuManager>().ShowWinner(winner);
        Debug.Log($"WINNER IS{(playerTwoDiff>playerOneDiff ? "player 1":"player 2")}");
    }
}
