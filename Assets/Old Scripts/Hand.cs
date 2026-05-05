using UnityEngine;

public class Hand : MonoBehaviour
{
    public Transform start;
    public Transform end;
    public float h = 0;

    public AnimationCurve curve;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        h += Time.deltaTime;
        if(h > 1)
        {
            h = 0;
        }

        transform.position = Vector2.Lerp(start.position, end.position, curve.Evaluate(h));
    }
}
