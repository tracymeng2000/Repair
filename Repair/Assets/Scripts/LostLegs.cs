
using UnityEngine;
using System.Collections;

public class LostLegs : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == Constants.PLAYER)
        {
            Destroy(gameObject);
            Destroy(GameObject.FindGameObjectWithTag(Constants.SEESAW_BOUNDARY).gameObject);
        }
    }
}