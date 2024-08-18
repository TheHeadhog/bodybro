using UnityEngine;

public class LegWorkout : Workout
{
    public override void StartWorkout(PlayerBody body)
    {
        TrainingData data = trainingData;

        body.ApplyModifiers(data);
    }
}
