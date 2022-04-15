using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandHitbox : MonoBehaviour
{
    public bool bActive = false;
    public AudioSource acHit;

    public ParticleSystem onHitParticles;

    private void OnTriggerEnter(Collider other)
    {
        if (bActive)
        {
            Hurtbox hb = other.GetComponent<Hurtbox>();

            if (hb != null)
            {
                hb.GetHit();
                CameraShake.Instance.AddTrauma(2.4f);
                CameraShake.Instance.Zoom();
                acHit.Play();
                acHit.volume = Random.Range(0.6f, 0.9f);
                acHit.pitch = Random.Range(0.9f, 1.1f);

                hb.anim.Play("Damaged1");
                onHitParticles.Play();
            }
        }

    }
}
