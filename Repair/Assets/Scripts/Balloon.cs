using UnityEngine;
using System.Collections;

public class Balloon : MonoBehaviour
{
    public float destroyPos;

    public float EPSILON;

    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        moveBalloon();
        if (System.Math.Abs(transform.position.x - destroyPos) < EPSILON)
        {
            Destroy(gameObject);
        }
    }

    private void moveBalloon()
    {
        rb.velocity = new Vector2(2, 0);
    }
}
