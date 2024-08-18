using System;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private float TimeRemaining;
    private TMP_Text TimerLabel;

    private void Start()
    {
        TimerLabel = gameObject.GetComponent<TMP_Text>();
    }

    private void Update()
    {
        TimeRemaining -= Time.deltaTime;
        TimerLabel.text = TimeSpan.FromSeconds(TimeRemaining).ToString(@"mm\:ss");
        if (TimeRemaining <= 0) Time.timeScale = 0f;
    }
}
