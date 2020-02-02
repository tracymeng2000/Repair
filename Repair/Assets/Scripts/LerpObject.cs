using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpObject : MonoBehaviour
{
    public Vector2 moveDistance;
    public float duration;

    private Vector2 endPosition;
    private Vector2 initalPosition;
    private Rigidbody2D rb;
    public AnimationCurve ac;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();

        initalPosition = transform.position;
        endPosition = initalPosition + moveDistance;
    }

    void Update()
    {
        //Track how far along the target should be
        float timeElapsed = Time.time;
        float percent = timeElapsed / duration;

        //Set the target's position based on the lerp and animation curve
        transform.position = Vector3.Lerp(initalPosition, endPosition, ac.Evaluate(percent)) +  new Vector3(0, 0, -1);
    }

    private void OnDrawGizmos()
    {
        if (!Application.isPlaying)
        {
            Gizmos.color = Color.magenta;
            Gizmos.DrawLine(transform.position, transform.position + new Vector3(moveDistance.x, moveDistance.y, 0));
            Gizmos.color = Color.white;
        } 
    }
}
