using UnityEngine;

public class Player : MonoBehaviour
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

    private void ApplyModifiers(TrainingData training)
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

    void Update()
    {
        // ApplyModifiers Test
        if(Input.GetKeyDown(KeyCode.B))
        {
            print("B pressed");
            TrainingData data = new TrainingData();
            data.HeadModifier = 1.0f;
            ApplyModifiers(data);
        }
        else if(Input.GetKeyDown(KeyCode.A))
        {
            print("A pressed");
            TrainingData data = new TrainingData();
            data.HeadModifier = -1.0f;
            ApplyModifiers(data);
        }
    }
}
