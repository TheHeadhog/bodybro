using UnityEngine;

public class ButtonMashWorkout : Workout
{
    public int buttonMashTarget = 10;

    private int buttonMashCount = 0;

    private ProgressBar progressBar;

    private void Awake()
    {
        progressBar = GetComponentInChildren<ProgressBar>();
    }
    private void Update()
    {
        if(activeTrainer == null)
        {
            return;
        }

        if(Input.GetKeyDown(activeTrainer.inputWorkout))
        {
            audioSource.Play();
            if(buttonMashTarget <= buttonMashCount++)
            {
                TrainingData data = trainingData;
                activeTrainer.body.ApplyModifiers(data);

                buttonMashCount = 0;
                EndWorkout();
            }
        }

        float target = buttonMashTarget;
        float progress = buttonMashCount;

        progressBar.SetProgress(progress / target);
    }
}
