using UnityEngine;

public class SquareMover : MonoBehaviour
{
    public float speed = 0.01f;
    float xMax = 8.3f;
    float xMin = -8.3f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //we can get access to the transform component by typing "transform"

        //on the transform we can access the position which is a Vector3
        //Vector3 contains x y and z values grouped together
        //transform.position.x += 1f;

       
    }

    // Update is called once per frame
    void Update()
    {
        //turn this object a random colour
        Vector3 newPosition = transform.position;

        //when assigning a value to float, we want to append "f" to the end
        newPosition.x += speed;
        transform.position = newPosition;

        if (newPosition.x > xMax)
        {
            speed = speed * -1f;
        }
        //also speed *= -1f;
        //also also speed = -speed;
        if (newPosition.x < xMin)
        {
            speed = speed * -1f;
        }
     
    }
}
