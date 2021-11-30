using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthColletible : MonoBehaviour
{
    public AudioClip audioClip;
    public GameObject effectParticle;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        RubyController rubyController = collision.GetComponent<RubyController>();
        if (rubyController != null)
        {

            if (rubyController.Health < rubyController.maxHealth) { 
            rubyController.ChangeHealth(1);
                rubyController.PlaySound(audioClip);
                Instantiate(effectParticle, transform.position, Quaternion.identity);
            Destroy(gameObject);
            }
        }
        
    }

}
