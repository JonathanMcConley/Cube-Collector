using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeBehavior : MonoBehaviour
{
    private float xBounds = 4.5f;
    private bool movingRight;
    private int randomStartingDirection;
    private float speed;
    public PlayerController player;
    // Start is called before the first frame update
    void Start()
    {
        speed = 3.0f;
        randomStartingDirection = Random.Range(0, 2);
        if (randomStartingDirection == 0 )
        {
            movingRight = true;
        }
        else
        {
            movingRight = false;
        }
     }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x >= xBounds) 
        {
            movingRight = false;
        }
        if(transform.position.x <= -xBounds) 
        {
            movingRight = true;
        }
        if(movingRight) 
        {
            MoveRight();
        }
        else if(!movingRight) 
        {
            MoveLeft();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        //If the player touches it, it gets destroyed. Note that the player is the only object in the game with a rigidbody element.
        player.collectCube();
        Destroy(gameObject);
    }

    private void MoveLeft() 
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }
    private void MoveRight() 
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }
}
