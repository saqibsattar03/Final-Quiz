using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallsCollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
       // Physics.IgnoreLayerCollision(6,0,true);
        if (gameObject.tag.Equals(collision.gameObject.tag) && gameObject.GetComponent<BallsCollision>().enabled)
        {
            FindObjectOfType<AudioManager>().Play("blast");
            collision.gameObject.GetComponent<BallsCollision>().enabled = true;
            Destroy(gameObject);
            GameManager.instance.ScoreUpdate(5);
        }
        else if (gameObject.tag != collision.gameObject.tag && gameObject.GetComponent<BallsCollision>().enabled) 
        {
           // SpwanManager.instance.ballPrefab.Add(gameObject);
        }
    }
}
