using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Vector3 movement;

    public float movement_speed = 0.005f;

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        gameObject.GetComponent<Animator>().SetFloat("x", movement.x);
        gameObject.GetComponent<Animator>().SetFloat("y", movement.y);
        gameObject.GetComponent<Animator>().SetFloat("speed", movement.sqrMagnitude);

    }

    void FixedUpdate()
    {

        gameObject.transform.position += movement_speed * movement * Time.deltaTime;
        
    }

}

