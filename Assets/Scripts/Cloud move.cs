using UnityEngine;

public class Cloudmove : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 newPos = transform.position;
        newPos.x += 0.01f;
        //transform.position = newPos;
        if(newPos.x > 15)
        {
            newPos.x = -15;
           
        }
transform.position = newPos;
    } 
}