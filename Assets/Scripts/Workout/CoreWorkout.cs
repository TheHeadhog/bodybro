using UnityEngine;

public class CoreWorkout : Workout
{
    public override void StartWorkout(PlayerBody body)
    {
        TrainingData data = trainingData;

        body.ApplyModifiers(data);
    }
}
