using UnityEngine;

public class ladybugmove : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 newPos = transform.position;
        newPos.x += 0.001f;
        //transform.position = newPos;
        if (newPos.x > 10)
        {
            newPos.x = -10;

        }
        transform.position = newPos;
    }
}
