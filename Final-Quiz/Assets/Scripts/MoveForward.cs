using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed = 300;
    private Rigidbody ballRB;
    private int range;
    private Transform direction;
    // Start is called before the first frame update
    void Start()
    {
        direction = GameObject.Find("Direction").GetComponent<Transform>();
        ballRB = GetComponent<Rigidbody>();
        range = 30;
    }

    // Update is called once per frame
    void Update()
    {

        MoveBall();
        OutofRange();
    }

    void MoveBall() 
    {
        ballRB.AddForce(direction.position * speed * Time.deltaTime, ForceMode.Impulse);
    }

    private void OutofRange()
    {
        if (transform.position.x > range || transform.position.x < -range)
        {
            Destroy(gameObject);
        }
        if (transform.position.z > range || transform.position.z < -range)
        {
            Destroy(gameObject);
        }
    }
}
