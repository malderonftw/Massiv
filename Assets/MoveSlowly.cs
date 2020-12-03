using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSlowly : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform sunrise;
    public Transform sunset;
    private Vector3 StartPos;
    private float t;

    // Time to move from sunrise to sunset position, in seconds.
    private float journeyTime = 20;

    // The time at which the animation started.
    private float startTime;

    void Start()
    {
        StartPos = sunrise.position;
        //StartCoroutine(MoveToPosition(sunrise, sunset.position, journeyTime));
    }

    void Update()
    {
        t += Time.deltaTime / journeyTime;
        transform.position = Vector3.Lerp(StartPos, sunset.position, t);
        
        
    }
    public IEnumerator MoveToPosition(Transform transform, Vector3 position, float timeToMove)
    {
        var currentPos = transform.position;
        var t = 0f;
        while (t < 1)
        {
            t += Time.deltaTime / timeToMove;
            transform.position = Vector3.Lerp(currentPos, position, t);
            yield return null;
        }
    }
}
