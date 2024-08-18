using UnityEngine;

public class ArmWorkout : Workout
{
    public override void StartWorkout(PlayerBody body)
    {
        TrainingData data = trainingData;

        body.ApplyModifiers(data);
    }
}
