using UnityEngine;
using System.Collections;

public class BalloonMaker : MonoBehaviour
{
    public GameObject balloon;

    private void Start()
    {
        InvokeRepeating("makeNewBalloon", 0f, 5.0f);
    }

    public void makeNewBalloon()
    {
        Instantiate(balloon, new Vector2(transform.position.x, transform.position.y), Quaternion.identity);
        balloon.tag = Constants.BALLOON;
    }
}
