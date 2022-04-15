using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hurtbox : MonoBehaviour
{
    public PlayerHealth health;
    public CharacterController cc;
    public Animator anim;

    private void Start()
    {
        health = transform.GetComponentInParent<PlayerHealth>();
        cc = transform.GetComponentInParent<CharacterController>();
    }

    public void GetHit()
    {
        print("I got hit!");
    }


}

public class EntityManager
{
    public PlayerHealth health;
    public CharacterControl cc;

    public void OnHit(float fDamage, Vector3 v3Knockback, float fStaminaDegen = 0, float fManaDamage = 0)
    {

    }
}
