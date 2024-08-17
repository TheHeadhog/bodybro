using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTrainer : MonoBehaviour
{
    [SerializeField] private PlayerBody body;
    private WorkoutMachine closestMachine;

    private bool isInWorkout = false;

    public bool IsInWorkout()
    {
        return isInWorkout;
    }

    // Update is called once per frame
    void Update()
    {
        if(closestMachine != null)
        {
            // Press B to start workout
            if(Input.GetKeyDown(KeyCode.B))
            {
                closestMachine.Train(body);
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        WorkoutMachine machine = col.GetComponent<WorkoutMachine>();
        if(machine != null)
        {
            print("Collided with a machine");
            closestMachine = machine;
        }
    }
    private void OnTriggerExit2D(Collider2D col)
    {
        WorkoutMachine machine = col.GetComponent<WorkoutMachine>();
        if(machine == closestMachine)
        {
            closestMachine = null;
        }
    }
}
