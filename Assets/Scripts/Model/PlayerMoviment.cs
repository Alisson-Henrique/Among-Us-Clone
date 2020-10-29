using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoviment : MonoBehaviour
{
    public Animator animator;
    public Rigidbody2D rigidbody2;
    public float speed;
    
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        rigidbody2 = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        if(h > 0)
        {
            animator.SetInteger("idAnimation", 1);
            transform.localScale = new Vector3(1, 1, 1);
        }
        else if(h < 0)
        {
            animator.SetInteger("idAnimation", 1);
            transform.localScale = new Vector3(-1, 1, 1);   
        }
        else if(v != 0){
            animator.SetInteger("idAnimation", 1);
        }
        else
        {
            animator.SetInteger("idAnimation", 0);
            
        }

        transform.Translate(new Vector3(h,v,0)*speed*Time.deltaTime);
        
       

    }
}
