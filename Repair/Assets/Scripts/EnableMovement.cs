using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class EnableMovement : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == Constants.BALLOON)
        {
            Destroy(collision.gameObject);
        }else if(collision.gameObject.tag == Constants.PLAYER)
        {
            SceneManager.LoadScene("Ending");
        }
    }
}
