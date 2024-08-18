using System;
using TMPro;
using UnityEngine;

public class TimeManager : MonoBehaviour
{
    [SerializeField] private float TimeRemaining;
    private TMP_Text TimerLabel;
    private bool GameOver;
    
    private void Start()
    {
        TimerLabel = gameObject.GetComponent<TMP_Text>();
        GameOver = false;
    }

    private void Update()
    {
        if(GameOver) return;
        TimeRemaining -= Time.deltaTime;
        TimerLabel.text = TimeSpan.FromSeconds(TimeRemaining).ToString(@"mm\:ss");
        if (!(TimeRemaining <= 0)) return;

        GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>().DecideWinner();
        GameOver = true;
    }
}
