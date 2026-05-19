using UnityEngine;

public class Spinner : MonoBehaviour
{
    public float zMax = 30;
    public float zMin = -30;
    public float speed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      //Debug.Log("hi");
     // Debug.Log(transform.eulerAngles);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 currentRotation = transform.eulerAngles;
        currentRotation.z += speed * Time.deltaTime;
        transform.eulerAngles = currentRotation;
        if (currentRotation.z > zMax)
        {
            Debug.Log("Crossing the upper threshold currentZ[" + currentRotation.z.ToString() + "] zMax[" + zMax.ToString() + "]");
            speed = -speed;
        }
        if (currentRotation.z < zMin)
        {
            Debug.Log("Crossing the lower threshold");
            speed = -speed;
        }
    }
}
