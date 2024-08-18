using System;
using TMPro;
using UnityEngine;

public class TimeManager : MonoBehaviour
{
    [SerializeField] private float TimeRemaining;
    private TMP_Text TimerLabel;
    private bool GameOver;
    private bool TriggeredTransitionOfBody = false;

    [SerializeField]private GameObject CutoutGameObject1;
    [SerializeField]private GameObject BodyGameObject1;
    [SerializeField]private GameObject CutoutBackgroundGameObject1;  
    [SerializeField]private GameObject CutoutGameObject2;
    [SerializeField]private GameObject BodyGameObject2;
    [SerializeField]private GameObject CutoutBackgroundGameObject2;
    
    private void Start()
    {
        TimerLabel = gameObject.GetComponent<TMP_Text>();
        GameOver = false;
        // SetBodyActive(false);
    }

    private void Update()
    {
        if(GameOver) return;

        // if (!TriggeredTransitionOfBody && TimeRemaining <= 55) SetBodyActive(true);
        
        TimeRemaining -= Time.deltaTime;
        TimerLabel.text = TimeSpan.FromSeconds(TimeRemaining).ToString(@"mm\:ss");
        if (!(TimeRemaining <= 0)) return;

        GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>().DecideWinner();
        GameOver = true;
    }

    private void SetBodyActive(bool isBodyActive)
    {
        TriggeredTransitionOfBody = isBodyActive;
        BodyGameObject1.SetActive(isBodyActive);
        BodyGameObject2.SetActive(isBodyActive);
        CutoutGameObject1.SetActive(!isBodyActive);
        CutoutGameObject2.SetActive(!isBodyActive);
        CutoutBackgroundGameObject1.SetActive(!isBodyActive);
        CutoutBackgroundGameObject2.SetActive(!isBodyActive);
    }
}
