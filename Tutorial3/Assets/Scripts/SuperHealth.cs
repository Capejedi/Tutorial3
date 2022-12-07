using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuperHealth : MonoBehaviour
{
    public AudioClip collectedClip;
    public ParticleSystem healParticle;

    void OnTriggerEnter2D(Collider2D other)
    {
        RubyController controller = other.GetComponent<RubyController>();

        if (controller != null)
        {
            if (controller.health < controller.maxHealth)
            {
                controller.ChangeHealth(4);
                Instantiate(healParticle, transform.position, Quaternion.identity);
                Destroy(gameObject);

                controller.PlaySound(collectedClip);
            }
        }

    }
}
