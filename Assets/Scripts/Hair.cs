using UnityEngine;

public class Hair : MonoBehaviour
{
    public float speed = 0.1f;
    public float xMax;
    public float xMin;

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
        //makes the hair move left and right to look like there's wind
        //bounces back and forth when it reaches its min and max x values
        if (newPosition.x > xMax)
        {
            speed = speed * -1f;
        }
        if (newPosition.x < xMin)
        {
            speed = speed * -1f;
        }
    }
}
