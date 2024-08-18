using UnityEngine;

public class HeadWorkout : Workout
{
    public override void StartWorkout(PlayerBody body)
    {
        TrainingData data = trainingData;

        body.ApplyModifiers(data);
    }
}
