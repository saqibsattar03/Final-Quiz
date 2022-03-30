using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallToShoot : MonoBehaviour
{

    public GameObject[] ballPrefab;
    MoveForward moveScript;
    BallsCollision collisionscript;

    // Update is called once per frame
    void Update()
    {
        ShootBall();
    }

    void ShootBall() 
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            int index = Random.Range(0, ballPrefab.Length);
            //Debug.Log(index);
            GameObject go = Instantiate(ballPrefab[index], transform.position, transform.rotation);
            GameManager.instance.UpdateColor(go.name);
		    Debug.Log(go.name);
			moveScript = go.GetComponent<MoveForward>();
			moveScript.enabled = true;
			collisionscript = go.GetComponent<BallsCollision>();
			collisionscript.enabled = true;
		}
    }
}
