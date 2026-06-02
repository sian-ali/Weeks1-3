using UnityEngine;

public class Bear : MonoBehaviour
{
    public float xSpeed;
    public float ySpeed;

    float xMax = 8.3f;
    float xMin = -8.3f;
    float yMax = 0f;
    float yMin = -3.5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.position = (Vector2) transform.position + Random.insideUnitCircle * 2;
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 newPosition = transform.position;
        newPosition.x += xSpeed * Time.deltaTime;
        newPosition.y += ySpeed * Time.deltaTime;
        transform.position = newPosition;

        if (newPosition.x >= xMax)
        {
            xSpeed = xSpeed * -1f;
        }
        if (newPosition.x < xMin)
        {
            xSpeed = xSpeed * -1f;
        }
        if (newPosition.y > yMax)
        {
            ySpeed = ySpeed * -1f;
        }
        if (newPosition.y < yMin)
        {
            ySpeed = ySpeed * -1f;
        }

    }
}