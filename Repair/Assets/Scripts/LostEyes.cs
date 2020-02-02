
using UnityEngine;
using System.Collections;

public class LostEyes : MonoBehaviour
{
    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(Vector2.right * 500f);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == Constants.PLAYER)
        {
            Destroy(gameObject);
            Destroy(GameObject.FindGameObjectWithTag(Constants.BLUR).gameObject);
            Destroy(GameObject.FindGameObjectWithTag(Constants.RIGHT_BOUNDARY).gameObject);
        }
    }
}