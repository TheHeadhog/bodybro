using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Workout : MonoBehaviour
{
    [SerializeField] protected TrainingData trainingData;
    protected PlayerTrainer activeTrainer = null;

    private SpriteRenderer machineSprite;

    private Animator animator;

    private void Awake()
    {
        machineSprite = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }
    public bool StartWorkout(PlayerTrainer trainer)
    {
        if(activeTrainer != null)
        {
            return false;
        }

        activeTrainer = trainer;
        // machineSprite.enabled = false;
        if(trainer.playerID == 1)
        {
            animator.SetTrigger("StartWorkoutP1");
        }
        else
        {
            animator.SetTrigger("StartWorkoutP2");
        }

        return true;
    }

    protected virtual void EndWorkout()
    {
        activeTrainer.WorkoutFinished();
        activeTrainer = null;
        animator.SetTrigger("EndWorkout");
        // machineSprite.enabled = true;
    }
}
