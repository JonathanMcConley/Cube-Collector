using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    public float xOffset;
    public float yOffset;
    public float zOffset;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // LateUpdate is called once per frame after Update is called
    void LateUpdate()
    {
        if (player != null) 
        {
            //If the player exists, the camera follows the player
            transform.position = new Vector3(player.transform.position.x + xOffset, player.transform.position.y + yOffset, player.transform.position.z + zOffset);
        }
    }
}
