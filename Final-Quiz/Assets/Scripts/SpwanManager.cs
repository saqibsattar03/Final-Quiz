using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpwanManager : MonoBehaviour
{
    //public GameObject[] ballPrefab;
    public List<GameObject> ballPrefab;

    PathMovement pathScript;
    private float seconds = 1f;

    public static SpwanManager instance;

    void Awake()
    {
        //Static instance
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;

        }
    }

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(BallSpawner());
        
    }
    IEnumerator BallSpawner() 
    {
        int index = Random.Range(0, ballPrefab.Count);
        GameObject obj = Instantiate(ballPrefab[index], transform.position, transform.rotation);
        pathScript = obj.GetComponent<PathMovement>();
        pathScript.enabled = true;

        yield return new WaitForSeconds(seconds);
        StartCoroutine(BallSpawner());
    }
}
