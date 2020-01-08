using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyaction : MonoBehaviour
{
    [SerializeField] private Transform enemy;
    [SerializeField] private Transform respawnPoint;
    [SerializeField] private Transform BB;
    [SerializeField] private Transform BBPoint;
    public movement checkHit;
    public breadaction bread;
    private Rigidbody erb;
    public float speed = -0.2f;
    private float tspeed;
    private Animator enemyanimation;
    private bool check = false;
    void Start()
    {
        erb = GetComponent<Rigidbody>();
        enemyanimation = this.GetComponent<Animator>();
        tspeed = speed;
    }

    // Update is called once per frame
    
    void FixedUpdate()
    {
        //float x = Time.time * speed;
        transform.localScale = new Vector3(-8.113075f, 8.113075f, 8.113075f);
        erb.velocity = new Vector3(-speed, erb.velocity.y, 0);
        if (check)//steal the bag 
        {
            transform.localScale = new Vector3(8.113075f, 8.113075f, 8.113075f);
            erb.velocity = new Vector3(speed, erb.velocity.y, 0);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
       if(other.tag == "Player")
       {
            other.GetComponent<health>().hp -= 1;
            Debug.Log("HP--");
            enemyanimation.SetBool("hit",true);
            if (other.GetComponent<health>().hp < 1)
            {
                check = true;
            }
            else 
            {
                reborn();
                
            }
        }
        if (other.tag == "break") 
        {
            checkHit.playeranimation.SetBool("detect", false);
            checkHit.playeranimation.SetBool("hit", true);
            //checkHit.playeranimation.SetBool("hit", false);
            BB.transform.position = BBPoint.transform.position;
            bread.go.SetActive(false);
            bread.speed = 0f;
            enemyanimation.SetBool("eat", true);
            speed = 0f;
            Invoke("reborn", 1);
          
        }
    }
    public void reborn() 
    {
        enemy.transform.position = respawnPoint.transform.position;
        enemyanimation.SetBool("eat", false);
        speed = tspeed;
    }
}
