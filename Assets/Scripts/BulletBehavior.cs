using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehavior : MonoBehaviour
{
    private float zBoundary;
    private float speed;
    // Start is called before the first frame update
    void Start()
    {
        speed = 30.0f;
        zBoundary = -49.0f;
    }

    // Update is called once per frame
    void Update()
    {
        //Checks to see if the game should despawn the bullet
        if (transform.position.z < zBoundary) 
        {
            Destroy(gameObject);
        }
        //Moves the bullet
        transform.Translate(Vector3.up * speed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        //If it hits the player, it and the player get destroyed.    
        Destroy(gameObject);
        Destroy(other.gameObject);
    }
}
