using UnityEngine;
using System.Collections;

public class Balloon : MonoBehaviour
{
    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(2, 0);
    }
}
