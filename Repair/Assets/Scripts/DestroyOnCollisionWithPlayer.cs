
using UnityEngine;
using System.Collections;

public class DestroyOnCollisionWithPlayer : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == Constants.PLAYER)
        {
            Destroy(gameObject);
        }
    }
}