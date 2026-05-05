using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
public class Eyes : MonoBehaviour
{
    public bool EYES = false;
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
        if (distance < 1)
        {
            EYES = true;
        }
        else
        {
            EYES = false;
        }
        if(EYES == true)
        {
            
            newPos.x += 0.01f;

        }
        if (newPos.x > -4)
        {
            newPos.x = -5;
        }
        transform.position = newPos;
    }
    }

