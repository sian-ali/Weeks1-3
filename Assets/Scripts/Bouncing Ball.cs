using UnityEngine;

public class BouncingBall : MonoBehaviour
{
    public float speed = 5f;
    float xMax = 8.3f;
    float xMin = -8.3f;
    float yMax = 4.5f;
    float yMin = -4.5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        Vector3 newPosition = transform.position;

        
        newPosition.x += speed * Time.deltaTime;
        newPosition.y += speed * Time.deltaTime;
        transform.position = newPosition;

        if (newPosition.x > xMax)
        {
            speed = speed * -1f;
        }
        if (newPosition.x < xMin)
        {
            speed = speed * -1f;
        }
        if (newPosition.y > yMax)
        {  
            speed = speed * -1f; 
        }
        if (newPosition.y < yMin)
        {
            speed = speed * -1f;
        }

    }
}
