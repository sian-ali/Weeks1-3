using UnityEngine;

public class Truck : MonoBehaviour
{
    //actually moon script
    public Vector3 startValue;
    public Vector3 endValue;

    public Vector3 currentValue;
    public float duration;

    float progress = 0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        progress += Time.deltaTime;
        currentValue = Vector3.Lerp(startValue, endValue, progress / duration);
        transform.position = currentValue;
        //makes the moon return to its starting position once it's completed its duration
        if (progress > duration)
        {
            progress = -0f;
        }
     
    }
}
