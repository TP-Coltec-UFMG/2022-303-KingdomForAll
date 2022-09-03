using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Player : MonoBehaviour
{
    public float speed;
    private float direction;
    public float JumpForce;
    private Rigidbody2D rig;
    private bool jump;
    private AudioSource audioS;
    public AudioClip pulo;
    private void Awake()
    {
        rig = GetComponent<Rigidbody2D>();
        audioS = GetComponent<AudioSource>();
    }

    private void Update()
    {
        direction = Input.GetAxisRaw("Horizontal");
        if(Input.GetKeyDown("space"))
        {
            jump = true;
        }
    }
    private void FixedUpdate()
    {
        rig.velocity = new Vector2(direction * speed, rig.velocity.y);
        if(jump)
        {
            audioS.clip = pulo;
            audioS.Play();
            rig.velocity = new Vector2(rig.velocity.x, JumpForce);
            jump = false;
        }
    }
    void OnCollisionEnter2D(Collision2D collider)
    {
        if(collider.gameObject.tag == "Morte")
        {
            transform.position = new Vector3(0, 3, 1);
        }
    }
}