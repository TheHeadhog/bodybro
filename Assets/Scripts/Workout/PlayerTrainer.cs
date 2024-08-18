using System.Collections;
using System.Collections.Generic;
using Script;
using UnityEngine;

public class PlayerTrainer : MonoBehaviour
{
    [SerializeField] public PlayerBody body;
    [SerializeField] public KeyCode inputBeginWorkout = KeyCode.B;
    [SerializeField] public KeyCode inputWorkout = KeyCode.B;
    [SerializeField] public int playerID = 1;

    private MovementController movement;

    private CircleCollider2D circleCollider;
    private CapsuleCollider2D capsuleCollider;
    private Workout closestWorkout;

    private void Awake()
    {
        movement = GetComponent<MovementController>();
        circleCollider = GetComponent<CircleCollider2D>();
        capsuleCollider = GetComponent<CapsuleCollider2D>();
    }

    private void SetEnablePlayer(bool enabled)
    {
        movement.enabled = enabled;
        circleCollider.enabled = enabled;
        capsuleCollider.enabled = enabled;
        foreach(SpriteRenderer renderer in GetComponentsInChildren<SpriteRenderer>())
        {
            renderer.enabled = enabled;
        }
    }
    public void WorkoutFinished()
    {
        print("Trainer ended the workout");
        SetEnablePlayer(true);
    }

    // Update is called once per frame
    void Update()
    {
        if(closestWorkout != null)
        {
            if(Input.GetKeyDown(inputBeginWorkout))
            {
                if(closestWorkout.StartWorkout(this))
                {
                    SetEnablePlayer(false);
                }
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        Workout machine = col.GetComponent<Workout>();
        if(machine != null)
        {
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
