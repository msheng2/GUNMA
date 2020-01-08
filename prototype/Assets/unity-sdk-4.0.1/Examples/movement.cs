using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public health checkhealth;
    public background bg;
    public float speed = 5f;
    public float move = 0f;
    private Rigidbody rb;
    public Animator playeranimation;
    private bool check = true;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent< Rigidbody >();
        playeranimation = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (check)
        {
            rb.velocity = new Vector3(move * speed, rb.velocity.y, 0);
            playeranimation.SetFloat("speed", rb.velocity.x);

        }
        else 
        {
            rb.velocity = new Vector3(0, 0, 0);
            playeranimation.SetFloat("speed", 0);
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "enemy")
        {
            
            Debug.Log("stop");
            check = false;
            if (checkhealth.hp <= 1) 
            {
                playeranimation.SetBool("nohealth", true);
                bg.scroll_speed = 0f;
            }
        }
        
    }
}
