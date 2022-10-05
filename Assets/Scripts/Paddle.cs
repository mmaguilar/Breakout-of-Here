using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class Paddle : MonoBehaviour
{
    public InputActionAsset inputActions;
    private InputAction direction;

    public float inputValue;
    public Rigidbody2D rb2d;

    public float paddleSpeed;
    public float minX; 
    public float maxX;

    
    // Start is called before the first frame update
    void Start()
    {   
        inputActions.Enable();
        direction = inputActions.FindAction("MovePaddle");
        rb2d = GetComponent<Rigidbody2D>();


    }

    // Update is called once per frame
    void Update()
    {
        inputValue = direction.ReadValue<float>();
        
    }

    private void FixedUpdate()
    {
        Vector2 moveVector = rb2d.position;
        moveVector.x += inputValue * Time.fixedDeltaTime * paddleSpeed;

        if(moveVector.x < minX)
        {
            moveVector.x = minX;
        }
        if(moveVector.x > maxX)
        {
            moveVector.x = maxX;
        }

        rb2d.MovePosition(moveVector);
    }
}
