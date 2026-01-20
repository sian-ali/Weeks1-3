using UnityEngine;

public class FirstScript : MonoBehaviour
{
    float speed = 0.01f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 newPos = transform.position;
        newPos.x += 0.1f;
        transform.position = newPos;
       // if (transform.position.x < 0 || transform.position.x > 8)
    }
}
