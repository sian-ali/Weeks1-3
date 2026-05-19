using UnityEngine;
using UnityEngine.InputSystem;

public class Turret : MonoBehaviour
{
    public Transform target;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //only update to face the target when the mouse is clicked:

        // bool isleftArrowKeyPressed = Keyboard.current.leftArrowKey.isPressed;
        bool leftMouseIsPressed = Mouse.current.leftButton.isPressed;
        Debug.Log(leftMouseIsPressed);
        bool leftMouseWasPressed = Mouse.current.leftButton.wasPressedThisFrame;
        bool leftMouseWasReleased = Mouse.current.leftButton.wasReleasedThisFrame;


        if (leftMouseWasPressed)
        {
            // Direction to B from A: B - A
            //the direction from this object towards the target
            Vector3 directionToTarget = target.position - transform.position;
            transform.up = directionToTarget;
        }
    }
}
