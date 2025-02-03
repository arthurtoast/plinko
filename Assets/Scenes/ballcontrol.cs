using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballcontrol : MonoBehaviour
{
    public float moveSpeed = 5;
    bool canMove = true;
    

    // Update is called once per frame
    void Update()
    {
        if (canMove == true)
        {
            Vector3 moveOffset = Vector3.zero;
            moveOffset.x = Input.GetAxis("horizontal");
            moveOffset.x = moveOffset.x * moveSpeed * Time.deltaTime;
            transform.position += moveOffset;


            if (Input.GetButtonDown("Fire1"))
            {
                canMove = false;
                GetComponent<Rigidbody>().isKinematic = false;
            }
        } 
    }
}
