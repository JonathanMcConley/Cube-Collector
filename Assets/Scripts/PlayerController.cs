using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float horizontalInput;
    private float forwardInput;
    private float speed;
    private float xBoundary;
    private float zBoundary;
    public GameObject[] cubes;
    public int cubesLeft;
    private bool won;
    // Start is called before the first frame update
    void Start()
    {
        speed = 10.0f;
        xBoundary = 4.5f;
        zBoundary = 48.0f;
        won = false;
        cubesLeft = cubes.Length;
    }

    // Update is called once per frame
    void Update()
    {
        //Moves the player
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * speed * Time.deltaTime * forwardInput);
        transform.Translate(Vector3.right * speed * Time.deltaTime * horizontalInput);
        //Keeps the player in bounds
        if (transform.position.x > xBoundary) 
        {
            transform.position = new Vector3(xBoundary, transform.position.y, transform.position.z);
        }
        if (transform.position.x < -xBoundary)
        {
            transform.position = new Vector3(-xBoundary, transform.position.y, transform.position.z);
        }
        if (transform.position.z < -zBoundary) 
        { 
            transform.position = new Vector3(transform.position.x, transform.position.y, -zBoundary);
        }
        if (transform.position.z > zBoundary) {
            transform.position = new Vector3(transform.position.x, transform.position.y, zBoundary);
        }
        //The condition of this if statement is never returning true for some reason.
        if (cubesLeft == 0)
        {
            won = true;
        }
    }

    public bool getWon() 
    {
        return won;
    }
    public void collectCube() 
    {
        cubesLeft -= 1;
    }
}
