using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cylinder : MonoBehaviour
{
    private Rigidbody rb;
    public float speed;
    public AudioSource sound;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        sound =GetComponent<AudioSource>();
	sound.Play();
    }

   
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.AddForce(movement * speed);
    }
}
