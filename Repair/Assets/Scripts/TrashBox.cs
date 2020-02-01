using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashBox : MonoBehaviour
{
    bool collided;

    public void Start()
    {
        collided = false;
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (!collided && collision.gameObject.tag == Constants.PLAYER)
        {
            collided = true;
            GameObject eyeActObj = GameObject.FindGameObjectWithTag(Constants.EYE_ACTIVATOR);
            if (eyeActObj) eyeActObj.SetActive(true);
        }
    }
}
