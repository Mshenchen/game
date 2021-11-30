using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Smart : MonoBehaviour
{
    public Transform rubytransform;
    public Transform ruby;
    private Vector3 player;
    public float speed = 1f;
    private Animator animator;
    // Start is called before the first frame update

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < ruby.position.x)
        {
            
            animator.SetBool("derict",true );
           
        }
        else
        {
            
            animator.SetBool("derict", false);
        }
   //     rubytransform.position = new Vector3(rubytransform.position.x + 1, rubytransform.position.y + 1, 0);
        transform.position = Vector3.MoveTowards(transform.position, rubytransform.position, 0.03f);
      //  transform.position =(rubytransform.position);
    }
}
