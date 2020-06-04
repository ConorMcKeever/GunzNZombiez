using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    public float moveSpeed;
    public float slideDist;
    public Rigidbody2D playerRigidbody;

    // Start is called before the first frame update
    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody2D>();   
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxisRaw("Horizontal") > 0f) 
        {
            playerRigidbody.velocity = new Vector3(moveSpeed, playerRigidbody.velocity.y, 0f);
        } else if (Input.GetAxisRaw("Horizontal") < 0f)
        {
            playerRigidbody.velocity = new Vector3(-moveSpeed, playerRigidbody.velocity.y, 0f);
        } else
        {

            playerRigidbody.velocity = new Vector3(0f, playerRigidbody.velocity.y, 0f);
        }

    }
}
