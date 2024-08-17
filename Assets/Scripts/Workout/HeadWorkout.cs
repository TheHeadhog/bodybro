using UnityEngine;

public class HeadWorkout : Workout
{
    [SerializeField] private float headModifier;
    [SerializeField] private float leftBicepsModifier;
    [SerializeField] private float rightBicepsModifier;

    public override void StartWorkout(PlayerBody body)
    {
        TrainingData data = new TrainingData();
        data.HeadModifier = headModifier;
        data.LeftBicepsModifier = leftBicepsModifier;
        data.RightBicepsModifier = rightBicepsModifier;

        body.ApplyModifiers(data);
    }
}
