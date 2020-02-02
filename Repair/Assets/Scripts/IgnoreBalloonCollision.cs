using UnityEngine;
using System.Collections;

public class IgnoreBalloonCollision : MonoBehaviour
{
    Collider2D collider;
    private void Start()
    {
        collider = GetComponent<Collider2D>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Balloon")
        {
            Physics2D.IgnoreCollision(collision.collider, collider);
        }
    }
}
