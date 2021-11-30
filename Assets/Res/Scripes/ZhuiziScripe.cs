using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZhuiziScripe : MonoBehaviour
{
    public float speed=-0.03f;
    public bool canMove = true;
    public void FixedUpdate()
    {
        if (!canMove) return;
        transform.Translate(speed, 0, 0);
       // if (transform.position.x < -5.0f)
       // {
       //     Destroy(gameObject);
      //  }
    }
    public void RandomHeight()
    {
        float r = Random.Range(-1.35f, 2.7f);
        transform.SetPositionAndRotation(new Vector3(transform.position.x, r, transform.position.z), transform.rotation);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        GameObject.Find("Manager").GetComponent<GammeM>().GameOver();
     //   Time.timeScale = 0;
    }
     
}
