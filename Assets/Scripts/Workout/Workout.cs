using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Workout : MonoBehaviour
{
    [SerializeField] protected TrainingData trainingData;
    protected PlayerTrainer activeTrainer = null;

    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    public bool StartWorkout(PlayerTrainer trainer)
    {
        if(activeTrainer != null)
        {
            return false;
        }

        activeTrainer = trainer;
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
    }
}
