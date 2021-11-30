using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class FlappyBird : MonoBehaviour
{
    public Rigidbody2D rb2d;
    public Animator animator;
    public GammeM gameManager;
    public float chengdu = 1f;
    public Transform birdimg;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!gameManager.isGameStart) return;
        if (Input.GetMouseButtonDown(0))
        {
            Fly();
        }
        birdimg.transform.DORotateQuaternion(Quaternion.Euler(0, 0, rb2d.velocity.y * chengdu),0.3f);
      //  birdimg.transform.rotation = ();
    }
    public void Fly()
    {
        rb2d.velocity = new Vector2(0, 5);
    }
    public void ChangeState(bool isFly,bool isSim=false)
    {
        if (isFly)
        {
            animator.SetInteger("State", 0);
        }
        else
        {
            animator.SetInteger("State", 1);
        }
        rb2d.simulated = isSim;
    }
}
