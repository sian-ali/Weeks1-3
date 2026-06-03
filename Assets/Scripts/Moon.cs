using UnityEngine;

public class Moon : MonoBehaviour
{
    //actually truck script
    public float speed = 0.1f;
    float xMax = 9.5f;
    float xMin = -9.5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position;
        newPosition.x += speed * Time.deltaTime;
        transform.position = newPosition;
        //makes the firetruck move back and forth across the screen getting faster every time it changes direction
        if (newPosition.x > xMax)
        {
            speed = speed * -1.01f;
        }
        if (newPosition.x < xMin)
        {
            speed = speed * -1.01f;
        }
    }
}
