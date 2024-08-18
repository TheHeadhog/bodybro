using UnityEngine;

public class ButtonMashWorkout : Workout
{
    public int buttonMashTarget = 10;

    private int buttonMashCount = 0;

    private void Update()
    {
        if(activeTrainer == null)
        {
            return;
        }

        if(Input.GetKeyDown(activeTrainer.inputWorkout))
        {
            if(buttonMashTarget <= buttonMashCount++)
            {
                TrainingData data = trainingData;
                activeTrainer.body.ApplyModifiers(data);

                buttonMashCount = 0;
                EndWorkout();
            }
        }
    }
}
