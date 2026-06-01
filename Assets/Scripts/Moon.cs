using UnityEngine;

public class Moon : MonoBehaviour
{
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

        if (newPosition.x > xMax)
        {
            speed = 0f;
            newPosition.x = xMin;
        }
        if (newPosition.x <= xMin)
        {
            speed = 5f;
        }
    }
}
