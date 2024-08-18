using UnityEngine;
using Random = System.Random;

public class PlayerBody : MonoBehaviour
{
    [SerializeField] private BodyPart head;
    [SerializeField] private BodyPart core;
    [SerializeField] private BodyPart leftBicep;
    [SerializeField] private BodyPart rightBicep;
    [SerializeField] private BodyPart leftForearm;
    [SerializeField] private BodyPart rightForearm;
    [SerializeField] private BodyPart leftQuad;
    [SerializeField] private BodyPart rightQuad;
    [SerializeField] private BodyPart leftCalf;
    [SerializeField] private BodyPart rightCalf;

    public void ApplyModifiers(TrainingData training)
    {
        head.ApplyModifier(training.HeadModifier);
        core.ApplyModifier(training.CoreModifier);

        // Arms
        leftBicep.ApplyModifier(training.LeftBicepsModifier);
        rightBicep.ApplyModifier(training.RightBicepsModifier);
        leftForearm.ApplyModifier(training.LeftForearmModifier);
        rightForearm.ApplyModifier(training.RightForearmModifier);

        // Legs
        leftQuad.ApplyModifier(training.LeftQuadModifier);
        rightQuad.ApplyModifier(training.RightQuadModifier);
        leftCalf.ApplyModifier(training.LeftCalfModifier);
        rightCalf.ApplyModifier(training.RightCalfModifier);
    }

    public void RandomizeStats()
    {
        var rand = new Random();
        head.growthStat = rand.Next(0, 6);
        core.growthStat = rand.Next(0, 6);
        leftBicep.growthStat = rand.Next(0, 6);
        rightBicep.growthStat = rand.Next(0, 6);
        leftForearm.growthStat = rand.Next(0, 6);
        rightForearm.growthStat = rand.Next(0, 6);
        leftQuad.growthStat = rand.Next(0, 6);
        rightQuad.growthStat = rand.Next(0, 6);
        leftCalf.growthStat = rand.Next(0, 6);
        rightCalf.growthStat = rand.Next(0, 6);
    }
}
