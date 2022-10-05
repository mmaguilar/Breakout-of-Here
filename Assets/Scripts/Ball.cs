using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Rigidbody2D BallRigidbody;
    public float ballSpeed;

    // Start is called before the first frame update
    void Start()
    {
        Reset();
    }

    // Update is called once per frame
    void Update()
    {

        
    }

    public void Reset(){
        transform.position = new Vector3(0,0,6);
        BallRigidbody.velocity = Random.insideUnitCircle.normalized * ballSpeed;
    }
}
