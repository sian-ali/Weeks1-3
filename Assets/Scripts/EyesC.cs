using UnityEngine;
using Unity.VisualScripting;
using UnityEngine.InputSystem;
public class EyesC : MonoBehaviour
{
    float xMin = -1.48f;
    float xMax = -1.17f;

    public bool eyes = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        float distance = Vector2.Distance(transform.position, mousePos);
        Vector2 newPos = transform.position;
        //sets the radius of where the mouse position will turn on the boolean
        if (distance < 2)
        {
            eyes = true;
        }
        else
        {
            eyes = false;
        }
        //makes the eyes move when mouse is hovering over
        if (eyes == true)
        {
            newPos.x += 0.01f;
        }
        //makes it so if they eye goes out of the socket it pops back in on the other side
        if (newPos.x > xMax)
        {
            newPos.x = xMin;
        }
        transform.position = newPos;
    }
}

