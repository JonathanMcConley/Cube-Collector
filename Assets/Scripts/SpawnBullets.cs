using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBullets : MonoBehaviour
{
    public GameObject bullet;
    private float randomShootTime;
    private float initialMinimum = 0.1f;
    private float initialMaximum = 1.0f;
    private float randomMinimum = 3.0f;
    private float randomMaximum = 5.0f;
    public PlayerController player;
    // Start is called before the first frame update
    void Start()
    {
        randomShootTime = Random.Range(initialMinimum, initialMaximum);
        Invoke("Shoot", randomShootTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Shoot() 
    {
        //If the player hasn't won, spawn bullets at a random interval; otherwise log that the player won (the spawner isn't turning off and I'm trying to fix that)
        if (!player.getWon())
        {
            Instantiate(bullet, transform.position, bullet.transform.rotation);
            randomShootTime = Random.Range(randomMinimum, randomMaximum);
            Invoke("Shoot", randomShootTime);
        }
        else 
        {
            Debug.Log("The Player Won");
        }
    }
}
