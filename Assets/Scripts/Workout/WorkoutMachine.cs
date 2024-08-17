using UnityEngine;

public class WorkoutMachine : MonoBehaviour
{
    // TECHDEBT!!!
    [SerializeField] private Workout workout;
    public void Train(PlayerBody body)
    {
        workout.StartWorkout(body);
    }
}
