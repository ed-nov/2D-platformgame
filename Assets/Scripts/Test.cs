using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Content;
using UnityEngine;

public class Test : MonoBehaviour
{
    Animator animator;
    Rigidbody2D rb2D;
    // Start is called before the first frame update
    void Start()
    {
        print("Start");
        animator = GetComponent<Animator>();
        rb2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float speed = 8;
        animator.SetTrigger("attack");
        animator.SetBool("run", false);
        animator.SetBool("jump", false);


        if (Input.GetKey("w") == true)
        {
            print("player pressed W");
            animator.SetBool("jump", true);
            rb2D.velocity = new Vector2(0, 5);
        }
        if (Input.GetKey("s") == true)
        {
            print("player pressed S");
            transform.position = new Vector2(transform.position.x, transform.position.y + (-speed * Time.deltaTime));
        }
        if (Input.GetKey("d") == true)
        {
            print("player pressed D");
            transform.position = new Vector2(transform.position.x + (speed * Time.deltaTime), transform.position.y);
            animator.SetBool("run", true);
        }
        if (Input.GetKey("a") == true)
        {
            print("player pressed A");
            transform.position = new Vector2(transform.position.x + (-speed * Time.deltaTime), transform.position.y);
            animator.SetBool("run", true);
        }

        
        if (Input.GetKey(KeyCode.LeftShift) == true && Input.GetKey("s") == true)
        {
            speed = 13;
            print("player pressed shift S");
            transform.position = new Vector2(transform.position.x, transform.position.y + (-speed * Time.deltaTime));
        }
        if (Input.GetKey(KeyCode.LeftShift) == true && Input.GetKey("d") == true)
        {
            speed = 13;
            print("player pressed shift D");
            transform.position = new Vector2(transform.position.x + (speed * Time.deltaTime), transform.position.y);
        }
        if (Input.GetKey(KeyCode.LeftShift) == true && Input.GetKey("a") == true)
        {
            speed = 13;
            print("player pressed shift A");
            transform.position = new Vector2(transform.position.x + (-speed * Time.deltaTime), transform.position.y);
        }

        if (Input.GetKey("q")== true)
        {
            print("player pressed Q");
            animator.SetTrigger("attack");
            
        }
        else if (Input.GetKey("q")== false)
        {
            animator.ResetTrigger("attack");
        }
    }
}
