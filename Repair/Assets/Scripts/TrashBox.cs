using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashBox : MonoBehaviour
{
    bool collided;
    public GameObject lostEyes;
    public void Start()
    {
        collided = false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!collided && collision.gameObject.tag == Constants.PLAYER)
        {
            collided = true;
            Instantiate(lostEyes, new Vector2(transform.position.x, transform.position.y + 1f), Quaternion.identity);
            lostEyes.tag = Constants.EYE_ACTIVATOR;
        }
    }
}