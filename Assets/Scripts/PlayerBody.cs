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

    [SerializeField]
    private float DowngradeProbability;

    [SerializeField]
    private float UpgradeProbability;
    public void ApplyModifiers(TrainingData training)
    {
        var headModifier = RandomizeModifier(training.HeadModifier);
        head.ApplyModifier(headModifier);

        var coreModifier = RandomizeModifier(training.CoreModifier);
        core.ApplyModifier(coreModifier);

        // Arms
        var armModifier = RandomizeModifier(training.LeftBicepsModifier);
        leftBicep.ApplyModifier(armModifier);
        rightBicep.ApplyModifier(armModifier);
        leftForearm.ApplyModifier(armModifier);
        rightForearm.ApplyModifier(armModifier);

        // Legs
        var legModifier = RandomizeModifier(training.LeftQuadModifier);
        leftQuad.ApplyModifier(legModifier);
        rightQuad.ApplyModifier(legModifier);
        leftCalf.ApplyModifier(legModifier);
        rightCalf.ApplyModifier(legModifier);
    }

    private float RandomizeModifier(float trainingModifier)
    {
        var modifier = trainingModifier;
        if (modifier == 0 && UnityEngine.Random.Range(0f, 1f) < DowngradeProbability) modifier = -1;
        else if (modifier == 1 && UnityEngine.Random.Range(0f, 1f) < UpgradeProbability) modifier = 2;
        return modifier;
    }

    public void RandomizeCutoutStats()
    {
        var rand = new Random();
        head.growthStat = rand.Next(2, 5);
        core.growthStat = rand.Next(2, 5);
        leftBicep.growthStat = leftForearm.growthStat = rightBicep.growthStat = rightForearm.growthStat = rand.Next(2, 5);
        leftQuad.growthStat = leftCalf.growthStat = rightQuad.growthStat = rightCalf.growthStat = rand.Next(2, 5);
    }

    public float CalculateDifference(PlayerBody other)
    {
        var differnece = 0f;
        differnece += Mathf.Abs(other.head.growthStat - head.growthStat);
        differnece += Mathf.Abs(other.core.growthStat - core.growthStat);
        differnece += Mathf.Abs(other.leftBicep.growthStat - leftBicep.growthStat);
        differnece += Mathf.Abs(other.rightBicep.growthStat - rightBicep.growthStat);
        differnece += Mathf.Abs(other.leftForearm.growthStat - leftForearm.growthStat);
        differnece += Mathf.Abs(other.rightForearm.growthStat - rightForearm.growthStat);
        differnece += Mathf.Abs(other.leftQuad.growthStat - leftQuad.growthStat);
        differnece += Mathf.Abs(other.rightQuad.growthStat - rightQuad.growthStat);
        differnece += Mathf.Abs(other.leftCalf.growthStat - leftCalf.growthStat);
        differnece += Mathf.Abs(other.rightCalf.growthStat - rightCalf.growthStat);
        return differnece;
    }
}
