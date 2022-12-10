using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float speed, maxSpeed, minSpeed;
    private Rigidbody rb;
    private bool canMove;
    Vector3 movement;
    public int score;
    BoxCollider bc;
    public bool delivered;
    Animator an;

    // Start is called before the first frame update
    void Start()
    {
        delivered = true;
        bc = GetComponent<BoxCollider>();
        movement = new Vector3(0, 0, 0);
        rb = GetComponent<Rigidbody>();
        an = GetComponent<Animator>();
        maxSpeed = 10f;
        minSpeed = 1f;
        speed = minSpeed;
        canMove = true;
    }

    private void Update()
    {
        if (canMove)
        {
            score += (int)speed/4;
            movement.z = speed * Time.deltaTime;
            transform.Translate(movement);
            an.SetFloat("Speed", speed);
        }
    }

    public float ChangeSpeed(float acceleration)
    {
        float lSpeed = speed + acceleration;
        if (lSpeed < maxSpeed && lSpeed > minSpeed)
        {
            speed = lSpeed;
            return lSpeed;
        } 
        else if (lSpeed>maxSpeed)
        {
            lSpeed = maxSpeed;
            speed = lSpeed;
            return lSpeed;
        } 
        else
        {
            lSpeed = minSpeed;
            speed = lSpeed;
            return lSpeed;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (canMove)
        {
            transform.position = new Vector3(0, 0, 0);
            score = 0;
            speed = 0;
        }
    }
    public void EndGame()
    {
        speed = 0;
        canMove = false;
        delivered = true;
        an.SetBool("Delivered", true);
    }
}
