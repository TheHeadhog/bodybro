
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private PlayerBody playerOneBody;
    private PlayerBody playerOneCutout;
    // Start is called before the first frame update
    void Start()
    {
        playerOneBody =GameObject.FindGameObjectWithTag("PlayerOneBody").GetComponent<PlayerBody>();
        playerOneCutout =GameObject.FindGameObjectWithTag("PlayerOneCutout").GetComponent<PlayerBody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DecideWinner()
    {
        var playerOneDiff = playerOneBody.CalculateDifference(playerOneCutout);
        return;
    }
}
