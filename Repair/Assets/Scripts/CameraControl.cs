using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public Transform player;
    public float fromPlayerZ, fromPlayerY;
    public bool followPlayer;
    void Update()
    {
        transform.position = new Vector3(player.position.x, followPlayer? player.position.y + 2f: fromPlayerY, fromPlayerZ);
    }
}