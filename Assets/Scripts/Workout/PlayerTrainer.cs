using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTrainer : MonoBehaviour
{
    [SerializeField] private PlayerBody body;
    [SerializeField] private KeyCode inputWorkout = KeyCode.B;
    private Workout closestWorkout;

    private bool isInWorkout = false;

    public bool IsInWorkout()
    {
        return isInWorkout;
    }

    // Update is called once per frame
    void Update()
    {
        if(closestWorkout != null)
        {
            if(Input.GetKeyDown(inputWorkout))
            {
                closestWorkout.StartWorkout(body);
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        Workout machine = col.GetComponent<Workout>();
        if(machine != null)
        {
            print("Collided with a machine");
            closestWorkout = machine;
        }
    }
    private void OnTriggerExit2D(Collider2D col)
    {
        Workout machine = col.GetComponent<Workout>();
        if(machine == closestWorkout)
        {
            closestWorkout = null;
        }
    }
}
