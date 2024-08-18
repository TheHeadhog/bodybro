using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Workout : MonoBehaviour
{
    [SerializeField] protected TrainingData trainingData;
    protected PlayerTrainer activeTrainer = null;

    private SpriteRenderer machineSprite;

    private void Awake()
    {
        machineSprite = GetComponent<SpriteRenderer>();
    }
    public bool StartWorkout(PlayerTrainer trainer)
    {
        if(activeTrainer != null)
        {
            return false;
        }

        activeTrainer = trainer;
        machineSprite.enabled = false;

        return true;
    }

    protected virtual void EndWorkout()
    {
        activeTrainer.WorkoutFinished();
        activeTrainer = null;
        machineSprite.enabled = true;
    }
}
