using UnityEngine;
using System.Collections;

public class IgnoreBalloonCollision : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {
        Physics2D.IgnoreLayerCollision(8, 9, true);
    }
}
